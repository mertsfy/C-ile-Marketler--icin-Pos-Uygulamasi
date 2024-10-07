using Igupos.models;
using Igupos.services;

namespace Igupos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Kullanıcı bilgilerini girin");
            }
            else
            {
                UserService service = new UserService();
                User user = service.Login(txtEmail.Text, txtPassword.Text);

                if (user != null)
                {
                    this.Hide();
                    if (user.Role == "ADMIN")
                    {
                        frmAdmin frm = new frmAdmin();
                        frm.ShowDialog();
                    }
                    else
                    {
                        frmCashier frm = new frmCashier();
                        frm.ShowDialog();
                    }
                }
            }
        }
    }
}
