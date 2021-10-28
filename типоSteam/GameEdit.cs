using Steam.DataBase;
using System;
using System.Drawing;
using System.Linq;
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
            Launcher.labelConsole.Text = "Открыто окно выбора изображения";
            if (dialogResult == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialogImage.FileName);
                ImagePath = openFileDialogImage.FileName;

                this.Height = 631;
                Launcher.labelConsole.Text = "Изменён размер окна добавления / изменения игры";

                pictureBox1.Image = image;
                Launcher.labelConsole.Text = "Установлено изображение";
            }
        }

        private void FormGameEdit_Load(object sender, EventArgs e)
        {
            SteamContext context = new SteamContext();
            Launcher.labelConsole.Text = "Открытие окна добавления / изменения игры";
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
            Launcher.labelConsole.Text = "Открыто окно выбора приложения";
            if (dialogResult == DialogResult.OK)
            {
                textBoxGamePath.Text = openFileDialogGame.FileName;
                Launcher.labelConsole.Text = "Установлен путь к приложению";
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
            SteamContext context = new SteamContext();

            string gameName = textBoxGameName.Text;
            string gamePath = textBoxGamePath.Text;
            string gameInfo = textBoxGameInfo.Text;

            if (gameName != null && gamePath != null)
            {
                if (Launcher.Game != null)
                {
                    UserGame game = context.UserGames.Single(u => u.Id == Launcher.Game.Id);

                    game.GameName = gameName;
                    game.GameInfo = gameInfo;
                    game.GamePath = gamePath;
                    game.ImagePath = ImagePath;

                    context.SaveChanges();
                    Launcher.Update_gameList();

                    MessageBox.Show("Игра успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Launcher.Game = null;
                    this.Close();
                }
                else
                {
                    context.UserGames.Add(new Steam.DataBase.UserGame()
                    {
                        UserId = Launcher.ID,
                        GameName = gameName,
                        GamePath = gamePath,
                        GameInfo = gameInfo,
                        ImagePath = ImagePath
                    });

                    context.SaveChanges();
                    Launcher.Update_gameList();

                    MessageBox.Show("Игра успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Нужные поля пустые", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            Launcher.Game = null;
        }
    }
}
