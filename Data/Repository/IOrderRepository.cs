using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();

        IEnumerable<Order> GetOrdersByMemberId(int id);

        Order GetOrderbyId(int id);

        void UpdateOrder(Order Order);

        void DeleteOrder(int id);

        void CreateOrder(Order Order);
    }
}