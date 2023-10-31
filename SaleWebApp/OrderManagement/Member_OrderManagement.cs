using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWebApp.OrderManagement
{
    public partial class Member_OrderManagement : Form
    {
        private OrderRepository orderRepository = new OrderRepository();
        private BindingSource source;
        private Member _member;

        public Member_OrderManagement(Member member)
        {
            InitializeComponent();
            this._member = member;
        }

        public void LoadListOrder()
        {
            var item = (
                    from order in AppDBContext.Instance.Orders
                    join orderDetail in AppDBContext.Instance.OrderDetails on order.OrderId equals orderDetail.OrderId
                    join product in AppDBContext.Instance.Products on orderDetail.ProductId equals product.ProductId
                    where (order.MemberId == _member.MemberId)
                    select new
                    {
                        orderId = order.OrderId,
                        productName = product.ProductName,
                        orderTime = order.OrderTime,
                        requiredTime = order.RequiredTime,
                        shippedTime = order.ShippedTime,
                        freight = order.Freight,
                    }).Distinct();

            source = new BindingSource();
            source.DataSource = item.ToList();
            dataGridView_Order.DataSource = source;
        }

        private void Member_OrderManagement_Load(object sender, EventArgs e)
        {
            LoadListOrder();
            dataGridView_Order.Enabled = false;
        }
    }
}