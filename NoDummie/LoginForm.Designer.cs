namespace NoDummie
{
    partial class LoginForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label_pw = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(293, 147);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(237, 20);
            this.textBox_username.TabIndex = 0;
            // 
            // textBox_pw
            // 
            this.textBox_pw.Location = new System.Drawing.Point(293, 188);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.Size = new System.Drawing.Size(237, 20);
            this.textBox_pw.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(348, 67);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(100, 40);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(255, 150);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(32, 13);
            this.label_user.TabIndex = 3;
            this.label_user.Text = "User:";
            // 
            // label_pw
            // 
            this.label_pw.AutoSize = true;
            this.label_pw.Location = new System.Drawing.Point(234, 191);
            this.label_pw.Name = "label_pw";
            this.label_pw.Size = new System.Drawing.Size(56, 13);
            this.label_pw.TabIndex = 4;
            this.label_pw.Text = "Password:";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(364, 247);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_pw);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.textBox_pw);
            this.Controls.Add(this.textBox_username);
            this.Name = "LoginForm";
            this.Text = "NoDummie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_pw;
        private System.Windows.Forms.Button button_login;
    }
}

