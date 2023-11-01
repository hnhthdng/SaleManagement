using BusinessObject;
using DataAccess.Repository;
using Nancy.Json;

namespace SaleWebApp
{
    public partial class frmLogin : Form
    {
        public static string EmailValue = "";
        private readonly MemberRepository memberRepository = new MemberRepository();

        public frmLogin()
        {
            InitializeComponent();
        }

        //Get Admin account from appsettings.json
        private Member getAdmin()
        {
            string json = string.Empty;
            using (StreamReader reader = new StreamReader("D:\\Major\\Kì 5\\PRN211\\Code\\SaleManagement\\SaleWebApp\\appsettings.json"))
            {
                json = reader.ReadToEnd();
            }
            JavaScriptSerializer jss = new JavaScriptSerializer();
            var obj = jss.Deserialize<dynamic>(json);
            var admin = new Member()
            {
                Email = obj["DefaultAccount"]["Email"],
                Password = obj["DefaultAccount"]["Password"]
            };
            return admin;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string email = textBox_Email.Text;
            string password = textBox_Password.Text;
            bool isMember = false;
            IEnumerable<Member> memberList = memberRepository.GetMembers();
            foreach (var member in memberList)
            {
                if (member.Email == email && member.Password == password)
                {
                    frm_SaleManagement frm = new frm_SaleManagement()
                    {
                        isAdmin = false
                    };
                    isMember = true;
                    EmailValue = member.Email;
                    MessageBox.Show("Login successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                    break;
                }
            }
            if (email.Equals(getAdmin().Email) && password.Equals(getAdmin().Password))
            {
                frm_SaleManagement frm = new frm_SaleManagement()
                {
                    isAdmin = true
                };
                isMember = true;
                EmailValue = getAdmin().Email;
                MessageBox.Show("Login successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            if (isMember == false)
            {
                MessageBox.Show("Enter email and password again!", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}