using Microsoft.EntityFrameworkCore;
using Steam.Account;
using Steam.App.Infrastructure;
using Steam.App.Models;
using Steam.DataBase;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Steam.WinForms
{
    public partial class Launcher : Form
    {
        public readonly IGameManager _gameManager = new GameManager();
        public readonly IAccountManager _accountManager = new AccountManager();

        public static bool Start { get; set; }
        public static long ID { get; set; }
        public static UserGame Game { get; set; }

        public Launcher()
        {
            InitializeComponent();
            contextMenuGameEdit.Items[0].Click += ShowAddGame;
            contextMenuGameEdit.Items[4].Click += ChangeNickname;
            contextMenuGameEdit.Items[5].Click += ChangeAccountInfo;
            contextMenuGameEdit.Items[1].Click += ShowEditGame;
            contextMenuGameEdit.Items[2].Click += GameDelete;
        }

        private void GameDelete(object sender, EventArgs e)
        {
            if (GameList.SelectedItems.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить игру", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    _gameManager.DeleteGame(ID, GameList.SelectedItems[0].Text);

                    UpdateGameList();
                }
            }
            else
            {
                MessageBox.Show("Игра не выбрана", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowEditGame(object sender, EventArgs e)
        {
            if (GameList.SelectedItems.Count != 0)
            {
                Game = _gameManager.GetUserGame(ID, GameList.SelectedItems[0].Text);
            }
            else
            {
                MessageBox.Show("Игра не выбрана", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            GameEdit formGameEdit = new GameEdit(this);
            formGameEdit.Show();
        }

        private void ChangeAccountInfo(object sender, EventArgs e)
        {
            labelConsole.Text = "Открытие окна изменения пароля";

            ChangeAccountInfo change_Pass = new ChangeAccountInfo();
            change_Pass.ShowDialog();
        }

        private void ChangeNickname(object sender, EventArgs e)
        {
            labelNick.Visible = false;

            textBoxNicname.Enabled = true;
            textBoxNicname.PlaceholderText = "Новый ник сюда";
            textBoxNicname.Focus();

            buttonCanselNick.Visible = true;
            buttonOkNick.Visible = true;

            labelConsole.Text = "Запуск системы изменения ника";
        }

        private void ShowAddGame(object sender, EventArgs e)
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
            labelConsole.Text = "Установка Никнейма";
            User user = _accountManager.GetUser(ID);

            string nick = user.Nikname;
            labelNick.Text = nick;
            labelConsole.Text = "Никнейм установлен";
            UpdateGameList();
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
            buttonOkNick.Visible = false;

            labelConsole.Text = "Изменение ника отменено";
        }

        private void buttonOKnick_Click(object sender, EventArgs e)
        {
            labelConsole.Text = "Начата процедура изменения ника";

            textBoxNicname.Enabled = false;
            textBoxNicname.PlaceholderText = "";

            buttonCanselNick.Visible = false;
            buttonOkNick.Visible = false;

            string nick = textBoxNicname.Text;
            _accountManager.ChangeNickname(ID, nick);

            textBoxNicname.Text = "";
            labelNick.Text = nick;
            labelNick.Visible = true;

            labelConsole.Text = "Ник успешно изменён";
        }

        private void SelectGame(object sender, EventArgs e)
        {
            if (GameList.SelectedItems.Count == 0)
            {
                return;
            }

            string gameName = GameList.SelectedItems[0].Text;
            UserGame game = _gameManager.GetUserGame(ID, gameName);

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

        public void UpdateGameList(string filter = null)
        {
            GameList.Items.Clear();

            foreach (UserGame game in _gameManager.GetUserGames(ID, filter))
            {
                Icon icon = Icon.ExtractAssociatedIcon(game.GamePath);
                int iconIndex = GetIconIndex(icon);

                GameList.Items.Add(game.GameName, iconIndex);
            }
        }

        private int GetIconIndex(Icon icon)
        {
            for (int i = 0; i < GameList.SmallImageList.Images.Count; i++)
            {
                if (icon.Equals(GameList.SmallImageList.Images[i]))
                {
                    return i;
                }
            }

            GameList.SmallImageList.Images.Add(icon);
            return GameList.SmallImageList.Images.Count - 1;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            UserGame game = _gameManager.GetUserGame(ID, GameList.SelectedItems[0].Text);
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
                UpdateGameList();
            }
            else
            {
                UpdateGameList(textBoxSearch.Text);
            }
        }

        private void GameInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
