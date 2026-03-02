using it_company.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace it_company
{
    public partial class FormLogin : Form
    {
        public Models.User CurrentUser { get; private set; }

        public bool IsGuest { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtLogin.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            using (var db = new ItCompanyContext())
            {
                var user = db.Users
                    .Where(w=>w.Email ==  txtLogin.Text && w.Pass == txtPassword.Text)
                    .FirstOrDefault();
                if (user != null)
                {
                    CurrentUser = user;
                    IsGuest = false;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            CurrentUser = null;
            IsGuest = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
