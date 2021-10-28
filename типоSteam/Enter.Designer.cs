
namespace Steam
{
    partial class Enter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPasword = new System.Windows.Forms.TextBox();
            this.labelEnter = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelErr = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBoxSave = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            resources.ApplyResources(this.textBoxLogin, "textBoxLogin");
            this.textBoxLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxLogin.Name = "textBoxLogin";
            // 
            // textBoxPasword
            // 
            resources.ApplyResources(this.textBoxPasword, "textBoxPasword");
            this.textBoxPasword.Name = "textBoxPasword";
            this.textBoxPasword.UseSystemPasswordChar = true;
            // 
            // labelEnter
            // 
            resources.ApplyResources(this.labelEnter, "labelEnter");
            this.labelEnter.ForeColor = System.Drawing.Color.White;
            this.labelEnter.Name = "labelEnter";
            // 
            // buttonEnter
            // 
            resources.ApplyResources(this.buttonEnter, "buttonEnter");
            this.buttonEnter.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEnter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonReg
            // 
            resources.ApplyResources(this.buttonReg, "buttonReg");
            this.buttonReg.BackColor = System.Drawing.SystemColors.Control;
            this.buttonReg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Name = "label2";
            // 
            // labelErr
            // 
            resources.ApplyResources(this.labelErr, "labelErr");
            this.labelErr.ForeColor = System.Drawing.Color.Red;
            this.labelErr.Name = "labelErr";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // checkBoxSave
            // 
            resources.ApplyResources(this.checkBoxSave, "checkBoxSave");
            this.checkBoxSave.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxSave.Name = "checkBoxSave";
            this.checkBoxSave.UseVisualStyleBackColor = true;
            this.checkBoxSave.CheckedChanged += new System.EventHandler(this.checkBoxSave_CheckedChanged);
            // 
            // Enter
            // 
            this.AcceptButton = this.buttonEnter;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.checkBoxSave);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelErr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelEnter);
            this.Controls.Add(this.textBoxPasword);
            this.Controls.Add(this.textBoxLogin);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Enter";
            this.ShowIcon = false;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.HelpButtonClick);
            this.Load += new System.EventHandler(this.Enter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxLogin;
        public System.Windows.Forms.TextBox textBoxPasword;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelErr;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBoxSave;
    }
}

