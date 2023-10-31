using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DataAccess
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-M665H91\\DUONGSQLSERVER;database=SaleManagement;UID=sa;password=123;Trusted_Connection=true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("Member")
                .HasMany(g => g.Orders)
                .WithOne(g => g.Member);
                entity.HasKey(e => e.MemberId);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order")
                .HasOne(g => g.Member)
                .WithMany(g => g.Orders)
                .HasForeignKey(f => f.MemberId);

                entity.HasKey(e => e.OrderId);

                entity.HasMany(g => g.OrderDetails)
                .WithOne(g => g.Order);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(g => new { g.ProductId, g.OrderId });

                entity.ToTable("OrderDetail")
                .HasOne(g => g.Product)
                .WithMany(g => g.OrderDetails)
                .HasForeignKey(g => g.ProductId);

                entity.ToTable("OrderDetail")
                .HasOne(g => g.Order)
                .WithMany(g => g.OrderDetails)
                .HasForeignKey(g => g.OrderId);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product")
                .HasMany(g => g.OrderDetails)
                .WithOne(g => g.Product);

                entity.HasKey(g => g.ProductId);
            });
        }

        private static AppDBContext instance = null;
        public static readonly object instanceLook = new object();

        public static AppDBContext Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new AppDBContext();
                    }
                    return instance;
                }
            }
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}