using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using типоSteam.dbl;

namespace типоSteam
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            SteamContext context = new SteamContext();
            User userLog = context.Users.FirstOrDefault(u => u.Login == textBoxLogin.Text);
            User userPas = context.Users.FirstOrDefault(u => u.Pasword == textBoxPasword.Text);
            if (userLog != null && userPas != null)
            {
                labelErr.Text = "верный логин или пароль";
                Console.Beep(260, 200);
                Console.Beep(370, 300);
                Console.WriteLine("верный логин или пароль");
            }
            else
            {
                labelErr.Text = "Неверный логин или пароль";
                Console.Beep(200, 300);
                Console.Beep(37, 500);
                Console.WriteLine("Heверный логин или пароль");
            }
        }
    }
}
