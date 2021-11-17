using Steam.App.Infrastructure;
using Steam.WinForms.Settings;
using System;
using System.Windows.Forms;
using AppModel = Steam.App.Models;

namespace Steam.WinForms.Account
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonReg_Click(object sender, EventArgs e)
        {
            Registration register = new Registration(this);
            register.ShowDialog();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            IAccount account = new AppModel.Account();

            string login = textBoxLogin.Text;
            string password = textBoxPasword.Text;

            try
            {
                Launcher.ID = account.Authorization(login, password);
                Launcher.Start = true;

                Console.Beep(260, 200);
                Console.Beep(370, 300);

                SaveSettings();
                Close();
            }
            catch (Exception ex)
            {
                labelErr.Text = ex.Message;

                Console.Beep(200, 300);
                Console.Beep(37, 500);
            }
        }

        private void SaveSettings()
        {
            if (checkBoxSave.Checked)
            {
                AccountSettings.Default.login = textBoxLogin.Text;
                AccountSettings.Default.password = textBoxPasword.Text;
            }

            AccountSettings.Default.savePass = checkBoxSave.Checked;
            AccountSettings.Default.Save();
        }

        private void CheckBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPasword.UseSystemPasswordChar = !checkBoxShowPass.Checked;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (AccountSettings.Default.savePass == true)
            {
                textBoxLogin.Text = AccountSettings.Default.login;
                textBoxPasword.Text = AccountSettings.Default.password;
                checkBoxSave.Checked = AccountSettings.Default.savePass;
            }

        }
    }
}
