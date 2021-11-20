
namespace Steam.WinForms
{
    partial class Launcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.labelNicname = new System.Windows.Forms.Label();
            this.GameScrn = new System.Windows.Forms.PictureBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonDop = new System.Windows.Forms.Button();
            this.contextMenuGameEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDELgame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemEditNick = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditPass = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelNick = new System.Windows.Forms.Label();
            this.textBoxNicname = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBarConsole = new System.Windows.Forms.ToolStripProgressBar();
            this.labelConsole = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonOkNick = new System.Windows.Forms.Button();
            this.buttonCanselNick = new System.Windows.Forms.Button();
            this.toolTipSteam = new System.Windows.Forms.ToolTip(this.components);
            this.GameList = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.GameInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameScrn)).BeginInit();
            this.contextMenuGameEdit.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNicname
            // 
            resources.ApplyResources(this.labelNicname, "labelNicname");
            this.labelNicname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNicname.Name = "labelNicname";
            this.toolTipSteam.SetToolTip(this.labelNicname, resources.GetString("labelNicname.ToolTip"));
            // 
            // GameScrn
            // 
            resources.ApplyResources(this.GameScrn, "GameScrn");
            this.GameScrn.BackColor = System.Drawing.Color.Transparent;
            this.GameScrn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameScrn.Name = "GameScrn";
            this.GameScrn.TabStop = false;
            this.toolTipSteam.SetToolTip(this.GameScrn, resources.GetString("GameScrn.ToolTip"));
            // 
            // buttonPlay
            // 
            resources.ApplyResources(this.buttonPlay, "buttonPlay");
            this.buttonPlay.Name = "buttonPlay";
            this.toolTipSteam.SetToolTip(this.buttonPlay, resources.GetString("buttonPlay.ToolTip"));
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonDop
            // 
            resources.ApplyResources(this.buttonDop, "buttonDop");
            this.buttonDop.ContextMenuStrip = this.contextMenuGameEdit;
            this.buttonDop.Name = "buttonDop";
            this.toolTipSteam.SetToolTip(this.buttonDop, resources.GetString("buttonDop.ToolTip"));
            this.buttonDop.UseVisualStyleBackColor = true;
            this.buttonDop.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuGameEdit
            // 
            resources.ApplyResources(this.contextMenuGameEdit, "contextMenuGameEdit");
            this.contextMenuGameEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddGame,
            this.toolStripMenuItemEditGame,
            this.toolStripMenuItemDELgame,
            this.toolStripSeparator,
            this.toolStripMenuItemEditNick,
            this.toolStripMenuItemEditPass});
            this.contextMenuGameEdit.Name = "contextMenuStrip1";
            this.contextMenuGameEdit.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolTipSteam.SetToolTip(this.contextMenuGameEdit, resources.GetString("contextMenuGameEdit.ToolTip"));
            this.contextMenuGameEdit.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItemAddGame
            // 
            resources.ApplyResources(this.toolStripMenuItemAddGame, "toolStripMenuItemAddGame");
            this.toolStripMenuItemAddGame.Name = "toolStripMenuItemAddGame";
            // 
            // toolStripMenuItemEditGame
            // 
            resources.ApplyResources(this.toolStripMenuItemEditGame, "toolStripMenuItemEditGame");
            this.toolStripMenuItemEditGame.Name = "toolStripMenuItemEditGame";
            // 
            // toolStripMenuItemDELgame
            // 
            resources.ApplyResources(this.toolStripMenuItemDELgame, "toolStripMenuItemDELgame");
            this.toolStripMenuItemDELgame.Name = "toolStripMenuItemDELgame";
            // 
            // toolStripSeparator
            // 
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            this.toolStripSeparator.Name = "toolStripSeparator";
            // 
            // toolStripMenuItemEditNick
            // 
            resources.ApplyResources(this.toolStripMenuItemEditNick, "toolStripMenuItemEditNick");
            this.toolStripMenuItemEditNick.Name = "toolStripMenuItemEditNick";
            // 
            // toolStripMenuItemEditPass
            // 
            resources.ApplyResources(this.toolStripMenuItemEditPass, "toolStripMenuItemEditPass");
            this.toolStripMenuItemEditPass.Name = "toolStripMenuItemEditPass";
            // 
            // textBoxSearch
            // 
            resources.ApplyResources(this.textBoxSearch, "textBoxSearch");
            this.textBoxSearch.Name = "textBoxSearch";
            this.toolTipSteam.SetToolTip(this.textBoxSearch, resources.GetString("textBoxSearch.ToolTip"));
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_keyPress);
            // 
            // buttonSearch
            // 
            resources.ApplyResources(this.buttonSearch, "buttonSearch");
            this.buttonSearch.Name = "buttonSearch";
            this.toolTipSteam.SetToolTip(this.buttonSearch, resources.GetString("buttonSearch.ToolTip"));
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelNick
            // 
            resources.ApplyResources(this.labelNick, "labelNick");
            this.labelNick.BackColor = System.Drawing.Color.Transparent;
            this.labelNick.Name = "labelNick";
            this.toolTipSteam.SetToolTip(this.labelNick, resources.GetString("labelNick.ToolTip"));
            // 
            // textBoxNicname
            // 
            resources.ApplyResources(this.textBoxNicname, "textBoxNicname");
            this.textBoxNicname.Name = "textBoxNicname";
            this.toolTipSteam.SetToolTip(this.textBoxNicname, resources.GetString("textBoxNicname.ToolTip"));
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBarConsole,
            this.labelConsole});
            this.statusStrip1.Name = "statusStrip1";
            this.toolTipSteam.SetToolTip(this.statusStrip1, resources.GetString("statusStrip1.ToolTip"));
            // 
            // progressBarConsole
            // 
            resources.ApplyResources(this.progressBarConsole, "progressBarConsole");
            this.progressBarConsole.Name = "progressBarConsole";
            // 
            // labelConsole
            // 
            resources.ApplyResources(this.labelConsole, "labelConsole");
            this.labelConsole.Name = "labelConsole";
            // 
            // buttonOKnick
            // 
            resources.ApplyResources(this.buttonOkNick, "buttonOKnick");
            this.buttonOkNick.BackColor = System.Drawing.Color.Transparent;
            this.buttonOkNick.FlatAppearance.BorderSize = 0;
            this.buttonOkNick.Name = "buttonOKnick";
            this.toolTipSteam.SetToolTip(this.buttonOkNick, resources.GetString("buttonOKnick.ToolTip"));
            this.buttonOkNick.UseVisualStyleBackColor = false;
            this.buttonOkNick.Click += new System.EventHandler(this.buttonOKnick_Click);
            // 
            // buttonCanselNick
            // 
            resources.ApplyResources(this.buttonCanselNick, "buttonCanselNick");
            this.buttonCanselNick.FlatAppearance.BorderSize = 0;
            this.buttonCanselNick.Name = "buttonCanselNick";
            this.toolTipSteam.SetToolTip(this.buttonCanselNick, resources.GetString("buttonCanselNick.ToolTip"));
            this.buttonCanselNick.UseVisualStyleBackColor = true;
            this.buttonCanselNick.Click += new System.EventHandler(this.buttonCanselNick_Click);
            // 
            // GameList
            // 
            resources.ApplyResources(this.GameList, "GameList");
            this.GameList.HideSelection = false;
            this.GameList.MultiSelect = false;
            this.GameList.Name = "GameList";
            this.GameList.SmallImageList = this.imageList1;
            this.toolTipSteam.SetToolTip(this.GameList, resources.GetString("GameList.ToolTip"));
            this.GameList.UseCompatibleStateImageBehavior = false;
            this.GameList.View = System.Windows.Forms.View.List;
            this.GameList.SelectedIndexChanged += new System.EventHandler(this.SelectGame);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Opera Снимок_2021-05-06_182649_www.pinterest.ru.png");
            // 
            // GameInfo
            // 
            resources.ApplyResources(this.GameInfo, "GameInfo");
            this.GameInfo.Name = "GameInfo";
            this.GameInfo.ReadOnly = true;
            this.toolTipSteam.SetToolTip(this.GameInfo, resources.GetString("GameInfo.ToolTip"));
            this.GameInfo.TextChanged += new System.EventHandler(this.GameInfo_TextChanged);
            // 
            // Launcher
            // 
            resources.ApplyResources(this, "$this");
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.GameInfo);
            this.Controls.Add(this.GameList);
            this.Controls.Add(this.buttonCanselNick);
            this.Controls.Add(this.buttonOkNick);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelNick);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonDop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.GameScrn);
            this.Controls.Add(this.textBoxNicname);
            this.Controls.Add(this.labelNicname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.toolTipSteam.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Launcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameScrn)).EndInit();
            this.contextMenuGameEdit.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNicname;
        private System.Windows.Forms.PictureBox GameScrn;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonDop;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.TextBox textBoxNicname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAddGame;
        private System.Windows.Forms.ContextMenuStrip contextMenuGameEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddGame;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditGame;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDELgame;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditNick;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditPass;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBarConsole;
        public System.Windows.Forms.ToolStripStatusLabel labelConsole;
        private System.Windows.Forms.Button buttonOkNick;
        private System.Windows.Forms.Button buttonCanselNick;
        private System.Windows.Forms.ToolTip toolTipSteam;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView GameList;

        private System.Windows.Forms.TextBox GameInfo;
    }
}