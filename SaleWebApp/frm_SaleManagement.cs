using BusinessObject;
using DataAccess.Repository;
using SaleWebApp.MemberManagement;
using SaleWebApp.OrderManagement;
using SaleWebApp.ProductManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWebApp
{
    public partial class frm_SaleManagement : Form
    {
        private MemberRepository memberRepository = new MemberRepository();
        private OrderRepository orderRepository = new OrderRepository();
        public bool isAdmin { get; set; }

        public frm_SaleManagement()
        {
            InitializeComponent();
        }

        private void frm_SaleManagement_Load(object sender, EventArgs e)
        {
            label_Name.Text = frmLogin.EmailValue;
        }

        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin == false)
            {
                var member = memberRepository.GetMemberByEmail(frmLogin.EmailValue);
                Member_MemberManagement frm = new Member_MemberManagement(member);
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                Admin_MemberManagement frm = new Admin_MemberManagement();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin == true)
            {
                Admin_ProductManagement frm = new Admin_ProductManagement();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this fuction menu !", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void orderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin == false)
            {
                var member = memberRepository.GetMemberByEmail(frmLogin.EmailValue);
                Member_OrderManagement frm = new Member_OrderManagement(member);
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                Admin_OrderManagement frm = new Admin_OrderManagement();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }
    }
}