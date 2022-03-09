namespace NoDummie
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_search_user = new System.Windows.Forms.Button();
            this.button_search_business = new System.Windows.Forms.Button();
            this.label_line_buttons = new System.Windows.Forms.Label();
            this.label_title_logins = new System.Windows.Forms.Label();
            this.label_user_dashboard = new System.Windows.Forms.Label();
            this.label_businesses_dashboard = new System.Windows.Forms.Label();
            this.label_user_count = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label_business_count = new System.Windows.Forms.Label();
            this.label_count_business = new System.Windows.Forms.Label();
            this.label_count_online = new System.Windows.Forms.Label();
            this.label_online_count = new System.Windows.Forms.Label();
            this.label_count_cities = new System.Windows.Forms.Label();
            this.label_cities_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(23, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1095, 2);
            this.label1.TabIndex = 3;
            // 
            // button_search_user
            // 
            this.button_search_user.Location = new System.Drawing.Point(455, 373);
            this.button_search_user.Name = "button_search_user";
            this.button_search_user.Size = new System.Drawing.Size(153, 23);
            this.button_search_user.TabIndex = 4;
            this.button_search_user.Text = "Dashboard";
            this.button_search_user.UseVisualStyleBackColor = true;
            this.button_search_user.Click += new System.EventHandler(this.button_search_user_Click);
            // 
            // button_search_business
            // 
            this.button_search_business.Location = new System.Drawing.Point(21, 281);
            this.button_search_business.Name = "button_search_business";
            this.button_search_business.Size = new System.Drawing.Size(153, 23);
            this.button_search_business.TabIndex = 5;
            this.button_search_business.Text = "Dashboard";
            this.button_search_business.UseVisualStyleBackColor = true;
            this.button_search_business.Click += new System.EventHandler(this.button_search_business_Click);
            // 
            // label_line_buttons
            // 
            this.label_line_buttons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_line_buttons.Location = new System.Drawing.Point(22, 259);
            this.label_line_buttons.Name = "label_line_buttons";
            this.label_line_buttons.Size = new System.Drawing.Size(780, 2);
            this.label_line_buttons.TabIndex = 6;
            // 
            // label_title_logins
            // 
            this.label_title_logins.AutoSize = true;
            this.label_title_logins.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_logins.Location = new System.Drawing.Point(17, 43);
            this.label_title_logins.Name = "label_title_logins";
            this.label_title_logins.Size = new System.Drawing.Size(328, 37);
            this.label_title_logins.TabIndex = 7;
            this.label_title_logins.Text = "System-Informationen";
            // 
            // label_user_dashboard
            // 
            this.label_user_dashboard.AutoSize = true;
            this.label_user_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_dashboard.Location = new System.Drawing.Point(451, 333);
            this.label_user_dashboard.Name = "label_user_dashboard";
            this.label_user_dashboard.Size = new System.Drawing.Size(43, 20);
            this.label_user_dashboard.TabIndex = 9;
            this.label_user_dashboard.Text = "User";
            // 
            // label_businesses_dashboard
            // 
            this.label_businesses_dashboard.AutoSize = true;
            this.label_businesses_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_businesses_dashboard.Location = new System.Drawing.Point(19, 239);
            this.label_businesses_dashboard.Name = "label_businesses_dashboard";
            this.label_businesses_dashboard.Size = new System.Drawing.Size(74, 20);
            this.label_businesses_dashboard.TabIndex = 11;
            this.label_businesses_dashboard.Text = "Gewerbe";
            // 
            // label_user_count
            // 
            this.label_user_count.AutoSize = true;
            this.label_user_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_count.Location = new System.Drawing.Point(20, 110);
            this.label_user_count.Name = "label_user_count";
            this.label_user_count.Size = new System.Drawing.Size(180, 20);
            this.label_user_count.TabIndex = 13;
            this.label_user_count.Text = "Anzahl Nutzer (gesamt):";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count.Location = new System.Drawing.Point(325, 110);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(18, 20);
            this.label_count.TabIndex = 14;
            this.label_count.Text = "0";
            // 
            // label_business_count
            // 
            this.label_business_count.AutoSize = true;
            this.label_business_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_business_count.Location = new System.Drawing.Point(470, 155);
            this.label_business_count.Name = "label_business_count";
            this.label_business_count.Size = new System.Drawing.Size(131, 20);
            this.label_business_count.TabIndex = 15;
            this.label_business_count.Text = "Anzahl Gewerbe:";
            // 
            // label_count_business
            // 
            this.label_count_business.AutoSize = true;
            this.label_count_business.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count_business.Location = new System.Drawing.Point(709, 155);
            this.label_count_business.Name = "label_count_business";
            this.label_count_business.Size = new System.Drawing.Size(18, 20);
            this.label_count_business.TabIndex = 16;
            this.label_count_business.Text = "0";
            // 
            // label_count_online
            // 
            this.label_count_online.AutoSize = true;
            this.label_count_online.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count_online.Location = new System.Drawing.Point(20, 155);
            this.label_count_online.Name = "label_count_online";
            this.label_count_online.Size = new System.Drawing.Size(109, 20);
            this.label_count_online.TabIndex = 17;
            this.label_count_online.Text = "Online Nutzer:";
            // 
            // label_online_count
            // 
            this.label_online_count.AutoSize = true;
            this.label_online_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_online_count.Location = new System.Drawing.Point(325, 155);
            this.label_online_count.Name = "label_online_count";
            this.label_online_count.Size = new System.Drawing.Size(18, 20);
            this.label_online_count.TabIndex = 18;
            this.label_online_count.Text = "0";
            // 
            // label_count_cities
            // 
            this.label_count_cities.AutoSize = true;
            this.label_count_cities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count_cities.Location = new System.Drawing.Point(469, 110);
            this.label_count_cities.Name = "label_count_cities";
            this.label_count_cities.Size = new System.Drawing.Size(114, 20);
            this.label_count_cities.TabIndex = 19;
            this.label_count_cities.Text = "Anzahl Städte:";
            // 
            // label_cities_count
            // 
            this.label_cities_count.AutoSize = true;
            this.label_cities_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cities_count.Location = new System.Drawing.Point(709, 110);
            this.label_cities_count.Name = "label_cities_count";
            this.label_cities_count.Size = new System.Drawing.Size(18, 20);
            this.label_cities_count.TabIndex = 20;
            this.label_cities_count.Text = "0";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(21, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(784, 2);
            this.label3.TabIndex = 21;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Produkt-Kategorien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Produkte";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Dashboard";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 510);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_cities_count);
            this.Controls.Add(this.label_count_cities);
            this.Controls.Add(this.label_online_count);
            this.Controls.Add(this.label_count_online);
            this.Controls.Add(this.label_count_business);
            this.Controls.Add(this.label_business_count);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label_user_count);
            this.Controls.Add(this.label_businesses_dashboard);
            this.Controls.Add(this.label_user_dashboard);
            this.Controls.Add(this.label_title_logins);
            this.Controls.Add(this.label_line_buttons);
            this.Controls.Add(this.button_search_business);
            this.Controls.Add(this.button_search_user);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "NoDummie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search_user;
        private System.Windows.Forms.Button button_search_business;
        private System.Windows.Forms.Label label_line_buttons;
        private System.Windows.Forms.Label label_title_logins;
        private System.Windows.Forms.Label label_user_dashboard;
        private System.Windows.Forms.Label label_businesses_dashboard;
        private System.Windows.Forms.Label label_user_count;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label_business_count;
        private System.Windows.Forms.Label label_count_business;
        private System.Windows.Forms.Label label_count_online;
        private System.Windows.Forms.Label label_online_count;
        private System.Windows.Forms.Label label_count_cities;
        private System.Windows.Forms.Label label_cities_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}