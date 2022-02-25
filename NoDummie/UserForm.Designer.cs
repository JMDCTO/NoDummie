namespace NoDummie
{
    partial class UserForm
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
            this.label_user_main_label = new System.Windows.Forms.Label();
            this.label_search_user_alias = new System.Windows.Forms.Label();
            this.label_serach_user_email = new System.Windows.Forms.Label();
            this.label_search_user_date = new System.Windows.Forms.Label();
            this.textBox_search_alias = new System.Windows.Forms.TextBox();
            this.textBox_search_email = new System.Windows.Forms.TextBox();
            this.textBox_search_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_search_trigger = new System.Windows.Forms.Button();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.label_help_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_response_type = new System.Windows.Forms.Label();
            this.label_num_results = new System.Windows.Forms.Label();
            this.label_results = new System.Windows.Forms.Label();
            this.button_search_user_reset = new System.Windows.Forms.Button();
            this.button_open_userinfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            this.SuspendLayout();
            // 
            // label_user_main_label
            // 
            this.label_user_main_label.AutoSize = true;
            this.label_user_main_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_main_label.Location = new System.Drawing.Point(8, 24);
            this.label_user_main_label.Name = "label_user_main_label";
            this.label_user_main_label.Size = new System.Drawing.Size(99, 20);
            this.label_user_main_label.TabIndex = 0;
            this.label_user_main_label.Text = "User suchen";
            // 
            // label_search_user_alias
            // 
            this.label_search_user_alias.AutoSize = true;
            this.label_search_user_alias.Location = new System.Drawing.Point(60, 76);
            this.label_search_user_alias.Name = "label_search_user_alias";
            this.label_search_user_alias.Size = new System.Drawing.Size(85, 13);
            this.label_search_user_alias.TabIndex = 1;
            this.label_search_user_alias.Text = "Alias/Username:";
            // 
            // label_serach_user_email
            // 
            this.label_serach_user_email.AutoSize = true;
            this.label_serach_user_email.Location = new System.Drawing.Point(110, 105);
            this.label_serach_user_email.Name = "label_serach_user_email";
            this.label_serach_user_email.Size = new System.Drawing.Size(35, 13);
            this.label_serach_user_email.TabIndex = 2;
            this.label_serach_user_email.Text = "Email:";
            // 
            // label_search_user_date
            // 
            this.label_search_user_date.AutoSize = true;
            this.label_search_user_date.Location = new System.Drawing.Point(12, 156);
            this.label_search_user_date.Name = "label_search_user_date";
            this.label_search_user_date.Size = new System.Drawing.Size(124, 13);
            this.label_search_user_date.TabIndex = 3;
            this.label_search_user_date.Text = "Datum der Registrierung:";
            // 
            // textBox_search_alias
            // 
            this.textBox_search_alias.Location = new System.Drawing.Point(152, 73);
            this.textBox_search_alias.Name = "textBox_search_alias";
            this.textBox_search_alias.Size = new System.Drawing.Size(100, 20);
            this.textBox_search_alias.TabIndex = 4;
            // 
            // textBox_search_email
            // 
            this.textBox_search_email.Location = new System.Drawing.Point(151, 98);
            this.textBox_search_email.Name = "textBox_search_email";
            this.textBox_search_email.Size = new System.Drawing.Size(100, 20);
            this.textBox_search_email.TabIndex = 5;
            // 
            // textBox_search_date
            // 
            this.textBox_search_date.Location = new System.Drawing.Point(151, 153);
            this.textBox_search_date.Name = "textBox_search_date";
            this.textBox_search_date.Size = new System.Drawing.Size(100, 20);
            this.textBox_search_date.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(15, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(758, 2);
            this.label1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "*optional";
            // 
            // button_search_trigger
            // 
            this.button_search_trigger.Location = new System.Drawing.Point(363, 111);
            this.button_search_trigger.Name = "button_search_trigger";
            this.button_search_trigger.Size = new System.Drawing.Size(92, 23);
            this.button_search_trigger.TabIndex = 10;
            this.button_search_trigger.Text = "Suche starten";
            this.button_search_trigger.UseVisualStyleBackColor = true;
            this.button_search_trigger.Click += new System.EventHandler(this.button_search_trigger_Click);
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.Location = new System.Drawing.Point(25, 210);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.Size = new System.Drawing.Size(745, 150);
            this.dataGridView_users.TabIndex = 11;
            // 
            // label_help_date
            // 
            this.label_help_date.AutoSize = true;
            this.label_help_date.Location = new System.Drawing.Point(257, 156);
            this.label_help_date.Name = "label_help_date";
            this.label_help_date.Size = new System.Drawing.Size(67, 13);
            this.label_help_date.TabIndex = 12;
            this.label_help_date.Text = "(yyyy-mm-dd)";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 2);
            this.label4.TabIndex = 13;
            // 
            // label_response_type
            // 
            this.label_response_type.AutoSize = true;
            this.label_response_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_response_type.ForeColor = System.Drawing.Color.Turquoise;
            this.label_response_type.Location = new System.Drawing.Point(540, 63);
            this.label_response_type.Name = "label_response_type";
            this.label_response_type.Size = new System.Drawing.Size(105, 26);
            this.label_response_type.TabIndex = 14;
            this.label_response_type.Text = "WAITING";
            // 
            // label_num_results
            // 
            this.label_num_results.AutoSize = true;
            this.label_num_results.ForeColor = System.Drawing.Color.Turquoise;
            this.label_num_results.Location = new System.Drawing.Point(545, 116);
            this.label_num_results.Name = "label_num_results";
            this.label_num_results.Size = new System.Drawing.Size(13, 13);
            this.label_num_results.TabIndex = 15;
            this.label_num_results.Text = "0";
            // 
            // label_results
            // 
            this.label_results.AutoSize = true;
            this.label_results.Location = new System.Drawing.Point(586, 116);
            this.label_results.Name = "label_results";
            this.label_results.Size = new System.Drawing.Size(59, 13);
            this.label_results.TabIndex = 16;
            this.label_results.Text = "Ergebnisse";
            // 
            // button_search_user_reset
            // 
            this.button_search_user_reset.Location = new System.Drawing.Point(363, 151);
            this.button_search_user_reset.Name = "button_search_user_reset";
            this.button_search_user_reset.Size = new System.Drawing.Size(92, 23);
            this.button_search_user_reset.TabIndex = 17;
            this.button_search_user_reset.Text = "Zurücksetzen";
            this.button_search_user_reset.UseVisualStyleBackColor = true;
            this.button_search_user_reset.Click += new System.EventHandler(this.button_search_user_reset_Click);
            // 
            // button_open_userinfo
            // 
            this.button_open_userinfo.Location = new System.Drawing.Point(363, 400);
            this.button_open_userinfo.Name = "button_open_userinfo";
            this.button_open_userinfo.Size = new System.Drawing.Size(75, 23);
            this.button_open_userinfo.TabIndex = 18;
            this.button_open_userinfo.Text = "Details";
            this.button_open_userinfo.UseVisualStyleBackColor = true;
            this.button_open_userinfo.Click += new System.EventHandler(this.button_open_userinfo_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_open_userinfo);
            this.Controls.Add(this.button_search_user_reset);
            this.Controls.Add(this.label_results);
            this.Controls.Add(this.label_num_results);
            this.Controls.Add(this.label_response_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_help_date);
            this.Controls.Add(this.dataGridView_users);
            this.Controls.Add(this.button_search_trigger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_search_date);
            this.Controls.Add(this.textBox_search_email);
            this.Controls.Add(this.textBox_search_alias);
            this.Controls.Add(this.label_search_user_date);
            this.Controls.Add(this.label_serach_user_email);
            this.Controls.Add(this.label_search_user_alias);
            this.Controls.Add(this.label_user_main_label);
            this.Name = "UserForm";
            this.Text = "User - Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_user_main_label;
        private System.Windows.Forms.Label label_search_user_alias;
        private System.Windows.Forms.Label label_serach_user_email;
        private System.Windows.Forms.Label label_search_user_date;
        private System.Windows.Forms.TextBox textBox_search_alias;
        private System.Windows.Forms.TextBox textBox_search_email;
        private System.Windows.Forms.TextBox textBox_search_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_search_trigger;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.Label label_help_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_response_type;
        private System.Windows.Forms.Label label_num_results;
        private System.Windows.Forms.Label label_results;
        private System.Windows.Forms.Button button_search_user_reset;
        private System.Windows.Forms.Button button_open_userinfo;
    }
}