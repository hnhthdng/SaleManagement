using BusinessObject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void CreateProduct(Product product)
        {
            AppDBContext.Instance.Products.Add(product);
            AppDBContext.Instance.SaveChanges();
        }

        public void DeleteProduct(string name)
        {
            var product = GetProductbyProductName(name);
            AppDBContext.Instance.Products.Remove(product);
            AppDBContext.Instance.SaveChanges();
        }

        public Product GetProductbyProductName(string name) => AppDBContext.Instance.Products.Where(product => product.ProductName == name).SingleOrDefault();

        public IEnumerable<Product> GetProducts() => AppDBContext.Instance.Products.ToList();

        public IEnumerable<Product> SearchProductFilter(Product product)
        {
            IQueryable<Product> query = GetProducts().AsQueryable();
            try
            {
                if (product.ProductId != 0)
                {
                    query = query.Where(x => x.ProductId == product.ProductId);
                }
                if (!string.IsNullOrEmpty(product.ProductName))
                {
                    query = query.Where(x => x.ProductName.Contains(product.ProductName, StringComparison.CurrentCultureIgnoreCase));
                }
                if (product.UnitPrice != 0)
                {
                    query = query.Where(x => x.UnitPrice == product.UnitPrice);
                }
                if (product.UnitsInStock != 0)
                {
                    query = query.Where(x => x.UnitsInStock == product.UnitsInStock);
                }
                if (query.ToList().Count == 0) { throw new Exception("Not found!!!"); }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return query.ToList<Product>();
        }

        public void UpdateProduct(Product product)
        {
            AppDBContext.Instance.Products.Update(product);
            AppDBContext.Instance.SaveChanges();
        }
    }
}