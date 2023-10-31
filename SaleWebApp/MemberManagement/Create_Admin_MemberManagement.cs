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

namespace SaleWebApp.MemberManagement
{
    public partial class Create_Admin_MemberManagement : Form
    {
        private MemberRepository memberRepository = new MemberRepository();

        public Create_Admin_MemberManagement()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.Email = txtb_Email.Text;
            member.City = txtb_City.Text;
            member.Country = txtb_Country.Text;
            member.CompanyName = txtb_CompanyName.Text;
            member.Password = txtb_Password.Text;
            memberRepository.CreateMember(member);
            MessageBox.Show("Create successfully", "Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}