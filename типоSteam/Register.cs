using Steam.DataBase;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Steam
{
    public partial class Register : Form
    {
        Enter Enter { get; set; }
        public Register(Enter enter) : this()
        {
            Enter = enter;
        }
        public Register()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            SteamContext context = new SteamContext();
            string login = textBoxLogin.Text;
            string pasword = textBoxPasword.Text;

            if (textBoxLogin.Text == "")
            {
                MessageBox.Show("Поле логин пустое", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxPasword.Text == "")
            {
                MessageBox.Show("Поле пароль пустое", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pasword == textBoxDirectPasword.Text)
            {
                User user = context.Users.FirstOrDefault(u => u.Login == login);
                if (user != null)
                {
                    MessageBox.Show("Этот логин занят", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    context.Users.Add(new User()
                    {
                        Login = login,
                        Pasword = pasword,
                        Nikname = login
                    });
                    context.SaveChanges();
                    MessageBox.Show("Акаунт успешно создан", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Enter.textBoxLogin.Text = login;
                    Enter.textBoxPasword.Text = pasword;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
