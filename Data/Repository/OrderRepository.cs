using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void CreateOrder(Order Order)
        {
            AppDBContext.Instance.Orders.Add(Order);
            AppDBContext.Instance.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            AppDBContext.Instance.Orders.Remove(GetOrderbyId(id));
            AppDBContext.Instance.SaveChanges();
        }

        public Order GetOrderbyId(int id) => AppDBContext.Instance.Orders.Where(g => g.OrderId == id).SingleOrDefault();

        public IEnumerable<Order> GetOrders() => AppDBContext.Instance.Orders.ToList();

        public IEnumerable<Order> GetOrdersByMemberId(int id) => AppDBContext.Instance.Orders.Where(g => g.MemberId == id).ToList();

        public void UpdateOrder(Order Order)
        {
            AppDBContext.Instance.Orders.Update(Order);
            AppDBContext.Instance.SaveChanges();
        }
    }
}