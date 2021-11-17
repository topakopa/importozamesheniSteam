using Steam.App.Infrastructure;
using System;
using System.Windows.Forms;
using AppModel = Steam.App.Models;

namespace Steam.WinForms.Account
{
    public partial class Registration : Form
    {
        Login Enter { get; set; }
        private readonly IAccount _account = new AppModel.Account();

        public Registration(Login enter) : this()
        {
            Enter = enter;
        }

        public Registration()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string pasword = textBoxPasword.Text;
            string directPassword = textBoxDirectPasword.Text;

            try
            {
                _account.Registration(login, pasword, directPassword);

                MessageBox.Show("Акаунт успешно создан", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Enter.textBoxLogin.Text = login;
                Enter.textBoxPasword.Text = pasword;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
