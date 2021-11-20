using Steam.DataBase;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Steam.WinForms
{
    public partial class GameEdit : Form
    {
        Launcher Launcher { get; set; }
        string ImagePath { get; set; }

        public GameEdit(Launcher launcher) : this()
        {
            Launcher = launcher;
        }

        public GameEdit()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialogImage.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialogImage.FileName);
                ImagePath = openFileDialogImage.FileName;

                this.Height = 631;

                pictureBox1.Image = image;
            }
        }

        private void FormGameEdit_Load(object sender, EventArgs e)
        {
            if (Launcher.Game != null)
            {
                textBoxGameName.Text = Launcher.Game.GameName;

                if (Launcher.Game.GameInfo != null)
                {
                    textBoxGameInfo.Text = Launcher.Game.GameInfo;
                }

                if (Launcher.Game.ImagePath != null)
                {
                    pictureBox1.Image = Image.FromFile(Launcher.Game.ImagePath);
                    this.Height = 631;
                }

                textBoxGamePath.Text = Launcher.Game.GamePath;

                this.Text = "Изменение игры";
                groupBox1.Text = "Изменение игры";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialogGame.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                textBoxGamePath.Text = openFileDialogGame.FileName;
            }
        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            this.Height = 339;
            textBoxGameName.Text = "";
            textBoxGameInfo.Text = "";
            textBoxGamePath.Text = "";
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            string gameName = textBoxGameName.Text;
            string gamePath = textBoxGamePath.Text;
            string gameInfo = textBoxGameInfo.Text;

            if (string.IsNullOrEmpty(gameName) && string.IsNullOrEmpty(gamePath))
            {
                MessageBox.Show("Нужные поля пустые", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Launcher.Game != null)
            {
                UserGame game = Launcher._gameManager.GetUserGame(Launcher.Game.Id);
                game.GameName = gameName;
                game.GameInfo = gameInfo;
                game.GamePath = gamePath;
                game.ImagePath = ImagePath;

                Launcher._gameManager.ChangeUserGameData(game);
                Launcher.UpdateGameList();

                MessageBox.Show("Игра успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Launcher.Game = null;
            }
            else
            {
                UserGame game = new UserGame();
                game.GameName = gameName;
                game.GameInfo = gameInfo;
                game.GamePath = gamePath;
                game.ImagePath = ImagePath;

                Launcher._gameManager.AddUserGame(game);
                Launcher.UpdateGameList();

                MessageBox.Show("Игра успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Launcher.Game = null;
        }
    }
}
