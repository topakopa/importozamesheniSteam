
namespace Steam.WinForms.Account
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.buttonReg = new System.Windows.Forms.Button();
            this.textBoxPasword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxDirectPasword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonReg
            // 
            resources.ApplyResources(this.buttonReg, "buttonReg");
            this.buttonReg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonReg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.UseCompatibleTextRendering = true;
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // textBoxPasword
            // 
            resources.ApplyResources(this.textBoxPasword, "textBoxPasword");
            this.textBoxPasword.Name = "textBoxPasword";
            // 
            // textBoxLogin
            // 
            resources.ApplyResources(this.textBoxLogin, "textBoxLogin");
            this.textBoxLogin.Name = "textBoxLogin";
            // 
            // textBoxDirectPasword
            // 
            resources.ApplyResources(this.textBoxDirectPasword, "textBoxDirectPasword");
            this.textBoxDirectPasword.Name = "textBoxDirectPasword";
            // 
            // Register
            // 
            this.AcceptButton = this.buttonReg;
            resources.ApplyResources(this, "$this");
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.textBoxDirectPasword);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.textBoxPasword);
            this.Controls.Add(this.textBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textBoxPasword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxDirectPasword;
    }
}