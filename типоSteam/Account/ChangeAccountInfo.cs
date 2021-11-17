using Steam.App.Infrastructure;
using Steam.DataBase;
using Steam.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;
using AppModel = Steam.App.Models;

namespace Steam.Account
{
    public partial class ChangeAccountInfo : Form
    {
        Launcher Launcher { get; set; }
        public ChangeAccountInfo(Launcher launcher) : this()
        {
            Launcher = launcher;
        }
        public ChangeAccountInfo()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SteamContext context = new SteamContext();
            User user = context.Users.Single(u => u.Id == Launcher.ID);

            if (textBoxOldPass.Text != user.Pasword)
            {
                MessageBox.Show("Неверный пароль", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                IAccount account = new AppModel.Account();
                account.ChangeLogin(user.Id, textBoxLogin.Text);
                MessageBox.Show("Логин успешно изменён", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            SteamContext context = new SteamContext();
            User user = context.Users.Single(u => u.Id == Launcher.ID);

            string old_pass = textBoxOldPass.Text;
            string pasword = textBoxPasword.Text;

            if (textBoxOldPass.Text != user.Pasword)
            {
                MessageBox.Show("Неверный пароль", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pasword != textBoxDirectPasword.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                IAccount account = new AppModel.Account();
                account.ChangePassword(user.Id, pasword);
                MessageBox.Show("Пароль успешно изменён", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Height = 283;

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
            this.Height = 180;

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
            if (dialogResult != DialogResult.Yes)
            {
                button1.Visible = false;
                label2.Visible = false;
                return;
            }

            try
            {
                IAccount account = new AppModel.Account();
                account.Delete(user.Id);
                MessageBox.Show("Аккаунт успешно удалён", "Грусно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
