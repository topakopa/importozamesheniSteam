
namespace Steam.Account
{
    partial class ChangeAccountInfo
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
            this.buttonReg = new System.Windows.Forms.Button();
            this.textBoxPasword = new System.Windows.Forms.TextBox();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.textBoxDirectPasword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonReg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonReg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonReg.Location = new System.Drawing.Point(7, 89);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(229, 52);
            this.buttonReg.TabIndex = 9;
            this.buttonReg.Text = "Сохранить";
            this.buttonReg.UseCompatibleTextRendering = true;
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // textBoxPasword
            // 
            this.textBoxPasword.Location = new System.Drawing.Point(7, 35);
            this.textBoxPasword.Name = "textBoxPasword";
            this.textBoxPasword.PasswordChar = '*';
            this.textBoxPasword.PlaceholderText = "Введите новый пароль";
            this.textBoxPasword.Size = new System.Drawing.Size(229, 21);
            this.textBoxPasword.TabIndex = 6;
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Location = new System.Drawing.Point(7, 8);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.PlaceholderText = "Введите старый пароль";
            this.textBoxOldPass.Size = new System.Drawing.Size(229, 21);
            this.textBoxOldPass.TabIndex = 5;
            // 
            // textBoxDirectPasword
            // 
            this.textBoxDirectPasword.Location = new System.Drawing.Point(7, 62);
            this.textBoxDirectPasword.Name = "textBoxDirectPasword";
            this.textBoxDirectPasword.PasswordChar = '*';
            this.textBoxDirectPasword.PlaceholderText = "Подтвердите новый пароль";
            this.textBoxDirectPasword.Size = new System.Drawing.Size(229, 21);
            this.textBoxDirectPasword.TabIndex = 10;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Enabled = false;
            this.textBoxLogin.Location = new System.Drawing.Point(300, 8);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.PlaceholderText = "Введите новый логин ";
            this.textBoxLogin.Size = new System.Drawing.Size(229, 21);
            this.textBoxLogin.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, -13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 180);
            this.label1.TabIndex = 12;
            this.label1.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Для подтверждения введите старый пароль \r\nв поле \"Введите старый пароль\"";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(7, 144);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 15);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Изменить логин";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(146, 144);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(90, 15);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Удалить аккаунт";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "Удалить аккаунт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(300, 144);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(95, 15);
            this.linkLabel3.TabIndex = 17;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Изменить пароль";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // Change_Pass
            // 
            this.AcceptButton = this.buttonReg;
            this.AccessibleDescription = "I don\'t know how it work";
            this.AccessibleName = "Registration";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(240, 163);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxDirectPasword);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.textBoxPasword);
            this.Controls.Add(this.textBoxOldPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Change_Pass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textBoxPasword;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.TextBox textBoxDirectPasword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}