using Steam.DataBase;
using Steam.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Steam
{
    public partial class Change_Pass : Form
    {
        Launcher Launcher { get; set; }
        public Change_Pass(Launcher launcher) : this()
        {
            Launcher = launcher;
        }
        public Change_Pass()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            SteamContext context = new SteamContext();
            string old_pass = textBoxOldPass.Text;
            string pasword = textBoxPasword.Text;
            User user = context.Users.Single(u => u.Id == Launcher.ID);

            if (textBoxOldPass.Text == "")
            {
                MessageBox.Show("Поле Старый пароль пустое", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User loginConf = context.Users.FirstOrDefault(u => u.Login == textBoxLogin.Text);
            if (textBoxLogin.Text != "")
            {
                if (textBoxOldPass.Text != user.Pasword)
                {
                    MessageBox.Show("Неверный пароль", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (loginConf != null)
                {
                    user.Login = textBoxLogin.Text;
                    MessageBox.Show("Логин успешно изменён", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else
                {
                    MessageBox.Show("Этот логин занят", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (textBoxPasword.Text == "")
            {
                MessageBox.Show("Поле Новый пароль пустое", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pasword == textBoxDirectPasword.Text)
            {


                if (textBoxOldPass.Text != user.Pasword)
                {
                    MessageBox.Show("Неверный пароль", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    user.Pasword = pasword;
                    context.SaveChanges();

                    MessageBox.Show("Пароль успешно изменён", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Width = 557;

            textBoxPasword.Enabled = false;
            textBoxDirectPasword.Enabled = false;
            textBoxLogin.Enabled = true;
            linkLabel1.Visible = false;
            linkLabel3.Visible = true;

            textBoxPasword.Text = "";
            textBoxDirectPasword.Text = "";
            this.Text = "Изменение логина";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Width = 260;

            textBoxPasword.Enabled = true;
            textBoxDirectPasword.Enabled = true;
            textBoxLogin.Enabled = false;
            linkLabel1.Visible = true;
            linkLabel3.Visible = false;

            textBoxLogin.Text = "";
            this.Text = "Изменение пароля";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Width = 557;

            button1.Visible = true;
            linkLabel2.Visible = false;

            this.Text = "Удаление акаунта";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SteamContext context = new SteamContext();
            User user = context.Users.Single(u => u.Id == Launcher.ID);

            if (user.Pasword != textBoxOldPass.Text)
            {
                MessageBox.Show("Пароль неверный или отсутсвует в соответствуешемся поле", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить акаунт", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                context.Users.Remove(user);
                context.SaveChanges();



                MessageBox.Show("Аккаунт успешно удалён", "Грусно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Exit();
            }
            else
            {
                button1.Visible = false;
                label2.Visible = false;
            }

        }


    }
}
