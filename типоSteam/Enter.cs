using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Steam;
using Steam.DataBase;
using Steam.WinForms;
using Steam.WinForms.WinForms;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace Steam
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }
        private void buttonReg_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.ShowDialog();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            SteamContext context = new SteamContext();
            User user = context.Users.FirstOrDefault(u => u.Login == textBoxLogin.Text && u.Pasword == textBoxPasword.Text);

            if (user != null)
            {
                Console.Beep(260, 200);
                Console.Beep(370, 300);

                Launcher.Start = true;
                Launcher.ID = user.Id;

                if (checkBoxSave.Checked)
                {
                    Settings1.Default.login = textBoxLogin.Text;
                    Settings1.Default.password = textBoxPasword.Text;
                    Settings1.Default.savePass = checkBoxSave.Checked;
                    Settings1.Default.Save();
                }
                else
                {
                    Settings1.Default.savePass = false;
                    Settings1.Default.Save();
                }

                this.Close();
            }
            else
            {
                labelErr.Text = "Неверный логин или пароль";
                Console.Beep(200, 300);
                Console.Beep(37, 500);
                Console.WriteLine("Heверный логин или пароль");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPasword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPasword.UseSystemPasswordChar = true;
            }
        }

        private void HelpButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void checkBoxSave_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Enter_Load(object sender, EventArgs e)
        {
            if (Settings1.Default.savePass == true)
            {
                textBoxLogin.Text = Settings1.Default.login;
                textBoxPasword.Text = Settings1.Default.password;
                checkBoxSave.Checked = Settings1.Default.savePass;
            }

        }
    }
}
