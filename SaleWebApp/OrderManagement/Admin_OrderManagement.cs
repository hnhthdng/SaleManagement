using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using SaleWebApp.MemberManagement;
using SaleWebApp.OrderManagement;
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
    public partial class Admin_OrderManagement : Form
    {
        private OrderRepository orderRepository = new OrderRepository();
        private BindingSource source;

        public Admin_OrderManagement()
        {
            InitializeComponent();
        }

        public void LoadListOrder()
        {
            var item = (
                    from order in AppDBContext.Instance.Orders
                    join member in AppDBContext.Instance.Members on order.MemberId equals member.MemberId
                    select new
                    {
                        orderId = order.OrderId,
                        memberId = member.MemberId,
                        email = member.Email,
                        orderTime = order.OrderTime,
                        requiredTime = order.RequiredTime,
                        shippedTime = order.ShippedTime,
                        freight = order.Freight,
                    }).Distinct();

            source = new BindingSource();
            source.DataSource = item.ToList();
            dataGridView_Order.DataSource = source;
        }

        private void Admin_OrderManagement_Load(object sender, EventArgs e)
        {
            LoadListOrder();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadListOrder();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Create_Admin_OrderManagement frm = new Create_Admin_OrderManagement();
            frm.ShowDialog();
            LoadListOrder();
            this.Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView_Order.SelectedRows.Count > 0)
            {
                var order = new Order();
                order = orderRepository.GetOrderbyId(Int32.Parse(dataGridView_Order.SelectedRows[0].Cells[0].Value.ToString()));

                Update_Admin_OrderManagement frm = new Update_Admin_OrderManagement(order);
                frm.ShowDialog();
                LoadListOrder();
                this.Show();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Order.SelectedRows.Count > 0)
            {
                var mess = MessageBox.Show("Are you sure to delete this member ?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (mess == DialogResult.OK)
                {
                    orderRepository.DeleteOrder(Int32.Parse(dataGridView_Order.SelectedRows[0].Cells[0].Value.ToString()));
                    dataGridView_Order.Rows.RemoveAt(dataGridView_Order.SelectedRows[0].Index);
                }
            }
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            var item = (
                     from order in AppDBContext.Instance.Orders
                     join member in AppDBContext.Instance.Members on order.MemberId equals member.MemberId
                     select new
                     {
                         orderId = order.OrderId,
                         memberId = member.MemberId,
                         email = member.Email,
                         orderTime = order.OrderTime,
                         requiredTime = order.RequiredTime,
                         shippedTime = order.ShippedTime,
                         freight = order.Freight,
                     }).Distinct().OrderByDescending(o => o.memberId);
            source.DataSource = item.ToList();
            dataGridView_Order.DataSource = source;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker_Start.Value;
            DateTime end = dateTimePicker_End.Value;
            var item = (
                     from order in AppDBContext.Instance.Orders
                     join member in AppDBContext.Instance.Members on order.MemberId equals member.MemberId
                     select new
                     {
                         orderId = order.OrderId,
                         memberId = member.MemberId,
                         email = member.Email,
                         orderTime = order.OrderTime,
                         requiredTime = order.RequiredTime,
                         shippedTime = order.ShippedTime,
                         freight = order.Freight,
                     }).Distinct().Where(g => g.orderTime >= start).Where(g => g.shippedTime <= end);
            source.DataSource = item.ToList();
            dataGridView_Order.DataSource = source;
        }
    }
}