
namespace SAVapp
{
    partial class LogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwdTxt = new System.Windows.Forms.TextBox();
            this.forgotPasswdLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CaskaydiaCove Nerd Font", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BackColor = System.Drawing.Color.White;
            this.UsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTxt.Font = new System.Drawing.Font("CaskaydiaCove NF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTxt.ForeColor = System.Drawing.Color.Black;
            this.UsernameTxt.Location = new System.Drawing.Point(113, 145);
            this.UsernameTxt.Multiline = true;
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(215, 18);
            this.UsernameTxt.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginButton.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.loginButton.Location = new System.Drawing.Point(29, 314);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(299, 42);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 1);
            this.panel2.TabIndex = 7;
            // 
            // passwdTxt
            // 
            this.passwdTxt.BackColor = System.Drawing.Color.White;
            this.passwdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwdTxt.Font = new System.Drawing.Font("CaskaydiaCove NF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwdTxt.ForeColor = System.Drawing.Color.Black;
            this.passwdTxt.Location = new System.Drawing.Point(113, 222);
            this.passwdTxt.Multiline = true;
            this.passwdTxt.Name = "passwdTxt";
            this.passwdTxt.PasswordChar = '*';
            this.passwdTxt.Size = new System.Drawing.Size(215, 18);
            this.passwdTxt.TabIndex = 2;
            this.passwdTxt.TabStop = false;
            this.passwdTxt.WordWrap = false;
            // 
            // forgotPasswdLabel
            // 
            this.forgotPasswdLabel.AutoSize = true;
            this.forgotPasswdLabel.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.forgotPasswdLabel.LinkColor = System.Drawing.Color.Blue;
            this.forgotPasswdLabel.Location = new System.Drawing.Point(139, 280);
            this.forgotPasswdLabel.Name = "forgotPasswdLabel";
            this.forgotPasswdLabel.Size = new System.Drawing.Size(207, 20);
            this.forgotPasswdLabel.TabIndex = 8;
            this.forgotPasswdLabel.TabStop = true;
            this.forgotPasswdLabel.Text = "Forgot your password ?";
            this.forgotPasswdLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswdLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(56, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "You don\'t have an account ?";
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountLabel.Font = new System.Drawing.Font("CaskaydiaCove NF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createAccountLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.createAccountLabel.Location = new System.Drawing.Point(76, 409);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(214, 22);
            this.createAccountLabel.TabIndex = 10;
            this.createAccountLabel.Text = "Create an Account";
            this.createAccountLabel.Click += new System.EventHandler(this.createAccountLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(12, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Log In to your Account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 489);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.createAccountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.forgotPasswdLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.passwdTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passwdTxt;
        private System.Windows.Forms.LinkLabel forgotPasswdLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label createAccountLabel;
        private System.Windows.Forms.Label label5;
    }
}

