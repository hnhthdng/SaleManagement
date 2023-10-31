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
    public partial class Update_Admin_OrderManagement : Form
    {
        private OrderRepository _orderRepository = new OrderRepository();
        private Order _order;

        public Update_Admin_OrderManagement(Order order)
        {
            InitializeComponent();
            _order = order;
        }

        private void Update_Admin_OrderManagement_Load(object sender, EventArgs e)
        {
            txtB_MemberID.Text = _order.MemberId.ToString();
            dateTimePicker_Order.Value = _order.OrderTime;
            dateTimePicker_Required.Value = _order.RequiredTime;
            dateTimePicker_Shipped.Value = _order.ShippedTime;
            txtB_Freight.Text = _order.Freight.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            _order.MemberId = Int32.Parse(txtB_MemberID.Text);
            _order.OrderTime = dateTimePicker_Order.Value;
            _order.RequiredTime = dateTimePicker_Required.Value;
            _order.ShippedTime = dateTimePicker_Shipped.Value;
            _order.Freight = decimal.Parse(txtB_Freight.Text);
            _orderRepository.UpdateOrder(_order);
            var mess = MessageBox.Show("Update Success", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}