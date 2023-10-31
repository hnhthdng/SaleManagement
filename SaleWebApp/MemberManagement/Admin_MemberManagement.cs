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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SaleWebApp.MemberManagement
{
    public partial class Admin_MemberManagement : Form
    {
        private MemberRepository memberRepository = new MemberRepository();
        private BindingSource source;

        public Admin_MemberManagement()
        {
            InitializeComponent();
        }

        public void LoadListMember()
        {
            source = new BindingSource();
            source.DataSource = memberRepository.GetMembers();
            dataGridView_Members.DataSource = source;
            this.dataGridView_Members.Columns["MemberId"].Visible = false;
            this.dataGridView_Members.Columns["Orders"].Visible = false;
        }

        private void Admin_MemberManagement_Load(object sender, EventArgs e)
        {
            LoadListMember();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadListMember();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Members.SelectedRows.Count > 0)
            {
                var mess = MessageBox.Show("Are you sure to delete this member ?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (mess == DialogResult.OK)
                {
                    memberRepository.DeleteMember(dataGridView_Members.SelectedRows[0].Cells[1].Value.ToString());
                    dataGridView_Members.Rows.RemoveAt(dataGridView_Members.SelectedRows[0].Index);
                }
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Create_Admin_MemberManagement frm = new Create_Admin_MemberManagement();
            frm.ShowDialog();
            LoadListMember();
            this.Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView_Members.SelectedRows.Count > 0)
            {
                var member = new Member();
                member = memberRepository.GetMemberByEmail(dataGridView_Members.SelectedRows[0].Cells[1].Value.ToString());

                Update_Admin_MemberManagement frm = new Update_Admin_MemberManagement(member);
                frm.ShowDialog();
                LoadListMember();
                this.Show();
            }
        }
    }
}