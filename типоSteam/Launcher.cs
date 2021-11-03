using Microsoft.EntityFrameworkCore;
using Steam.Account;
using Steam.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Steam.WinForms
{
    public partial class Launcher : Form
    {
        public static bool Start { get; set; }
        public static long ID { get; set; }
        public static UserGame Game { get; set; }
        public Launcher()
        {
            InitializeComponent();
            contextMenuGameEdit.Items[0].Click += ShowEditGame;
            contextMenuGameEdit.Items[4].Click += ChangeNick;
            contextMenuGameEdit.Items[5].Click += ChangePass;
            contextMenuGameEdit.Items[1].Click += ShowEditGame1;
            contextMenuGameEdit.Items[2].Click += GameDEL;
        }

        private void GameDEL(object sender, EventArgs e)
        {
            SteamContext steamContext = new SteamContext();

            if (GameList.SelectedItems.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить игру", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    UserGame game = steamContext.UserGames.Single(users => users.UserId == ID && users.GameName == GameList.SelectedItems[0].Text);
                    steamContext.UserGames.Remove(game);
                    steamContext.SaveChanges();
                    Update_gameList();

                }
            }
            else
            {
                MessageBox.Show("Игра не выбрана", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ShowEditGame1(object sender, EventArgs e)
        {
            SteamContext steamContext = new SteamContext();
            if (GameList.SelectedItems.Count != 0)
            {
                Game = steamContext.UserGames.Single(users => users.UserId == ID && users.GameName == GameList.SelectedItems[0].Text);
            }
            else
            {
                MessageBox.Show("Игра не выбрана", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GameEdit formGameEdit = new GameEdit(this);
            formGameEdit.Show();

        }

        private void ChangePass(object sender, EventArgs e)
        {
            labelConsole.Text = "Открытие окна изменения пароля";

            ChangeAccountInfo change_Pass = new ChangeAccountInfo();
            change_Pass.ShowDialog();
        }

        private void ChangeNick(object sender, EventArgs e)
        {
            labelNick.Visible = false;

            textBoxNicname.Enabled = true;
            textBoxNicname.PlaceholderText = "Новый ник сюда";
            textBoxNicname.Focus();

            buttonCanselNick.Visible = true;
            buttonOKnick.Visible = true;

            labelConsole.Text = "Запуск системы изменения ника";
        }

        private void ShowEditGame(object sender, EventArgs e)
        {
            GameEdit formGameEdit = new GameEdit(this);
            formGameEdit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonDop.ContextMenuStrip.Show(buttonDop, new Point(0, 0));
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            SteamContext steamContext = new SteamContext();

            labelConsole.Text = "Установка Никнейма";
            User user = steamContext.Users.Include(u => u.UserGames).Single(users => users.Id == ID);

            string nick = user.Nikname;
            labelNick.Text = nick;
            labelConsole.Text = "Никнейм установлен";
            Update_gameList();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }



        private void buttonCanselNick_Click(object sender, EventArgs e)
        {
            labelNick.Visible = true;

            textBoxNicname.Enabled = false;
            textBoxNicname.PlaceholderText = "";
            textBoxNicname.Text = "";

            buttonCanselNick.Visible = false;
            buttonOKnick.Visible = false;

            labelConsole.Text = "Изменение ника отменено";
        }

        private void buttonOKnick_Click(object sender, EventArgs e)
        {
            labelConsole.Text = "Начата процедура изменения ника";

            textBoxNicname.Enabled = false;
            textBoxNicname.PlaceholderText = "";

            buttonCanselNick.Visible = false;
            buttonOKnick.Visible = false;

            string nick = textBoxNicname.Text;
            SteamContext context = new SteamContext();

            User user = context.Users.Single(u => u.Id == ID);
            user.Nikname = nick;

            context.SaveChanges();

            textBoxNicname.Text = "";
            labelNick.Text = nick;
            labelNick.Visible = true;

            labelConsole.Text = "Ник успешно изменён";
        }

        private void Select_game(object sender, EventArgs e)
        {
            SteamContext context = new SteamContext();
            string game_name;

            if (GameList.SelectedItems.Count > 0)
            {
                game_name = GameList.SelectedItems[0].Text;
            }
            else
            {
                return;
            }

            User user = context.Users.Include(u => u.UserGames).Single(u => u.Id == ID);
            UserGame game = user.UserGames.FirstOrDefault(u => u.GameName == game_name);

            if (game.ImagePath != null)
            {
                GameScrn.Image = Image.FromFile(game.ImagePath);
            }
            else
            {
                GameScrn.Image = null;
            }

            if (game.GameInfo != null)
            {
                GameInfo.Text = game.GameInfo;
            }
            else
            {
                GameInfo.Text = "";
            }
        }

        public void Update_gameList(string filter = null)
        {
            SteamContext context = new SteamContext();
            User user = context.Users.Include(u => u.UserGames).Single(users => users.Id == ID);
            UserGame[] games = user.UserGames.ToArray();

            GameList.Items.Clear();

            if (filter != null)
            {
                games = games.Where(u => u.GameName.ToLower().Contains(filter.ToLower())).ToArray();
            }

            foreach (UserGame game in games)
            {
                Icon icon = Icon.ExtractAssociatedIcon(game.GamePath);
                bool if_find_icon = false;

                for (int i = 0; i < GameList.SmallImageList.Images.Count; i++)
                {
                    if (icon.Equals(GameList.SmallImageList.Images[i]))
                    {
                        if_find_icon = true;
                        GameList.Items.Add(game.GameName, i);
                    }

                }
                if (if_find_icon == false)
                {
                    GameList.SmallImageList.Images.Add(icon);
                    GameList.Items.Add(game.GameName, GameList.SmallImageList.Images.Count - 1);
                }

            }

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            SteamContext steamContext = new SteamContext();
            UserGame game = steamContext.UserGames.Single(users => users.UserId == ID && users.GameName == GameList.SelectedItems[0].Text);

            Process.Start(game.GamePath);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameInfo.Enabled = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search_keyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }
        private void Search()
        {
            if (textBoxSearch.Text == "")
            {
                Update_gameList();
            }
            else
            {
                Update_gameList(textBoxSearch.Text);
            }
        }

        private void GameInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
