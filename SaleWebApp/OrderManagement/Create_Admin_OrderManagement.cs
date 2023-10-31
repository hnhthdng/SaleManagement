using BusinessObject;
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
    public partial class Create_Admin_OrderManagement : Form
    {
        private OrderRepository orderRepository = new OrderRepository();

        public Create_Admin_OrderManagement()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.MemberId = int.Parse(txtB_MemberID.Text);
            order.OrderTime = dateTimePicker_Order.Value;
            order.RequiredTime = dateTimePicker_Required.Value;
            order.ShippedTime = dateTimePicker_Shipped.Value;
            order.Freight = int.Parse(txtB_Freight.Text);
            orderRepository.CreateOrder(order);
            MessageBox.Show("Create Successfully", "Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}