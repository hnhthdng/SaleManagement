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
    public partial class Member_MemberManagement : Form
    {
        private MemberRepository memberRepository = new MemberRepository();
        public Member _member { get; set; }

        public Member_MemberManagement(Member member)
        {
            InitializeComponent();
            _member = member;
        }

        private void Member_MemberManagement_Load(object sender, EventArgs e)
        {
            txtb_Email.Text = _member.Email;
            txtb_CompanyName.Text = _member.CompanyName;
            txtb_City.Text = _member.City;
            txtb_Country.Text = _member.Country;
            txtb_Password.Text = _member.Password;
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            txtb_Email.Text = _member.Email;
            txtb_CompanyName.Text = _member.CompanyName;
            txtb_City.Text = _member.City;
            txtb_Country.Text = _member.Country;
            txtb_Password.Text = _member.Password;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            _member.Email = txtb_Email.Text;
            _member.CompanyName = txtb_CompanyName.Text;
            _member.City = txtb_City.Text;
            _member.Country = txtb_Country.Text;
            _member.Password = txtb_Password.Text;
            memberRepository.UpdateMember(_member);
            MessageBox.Show("Update successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}