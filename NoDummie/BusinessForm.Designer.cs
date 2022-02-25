namespace NoDummie
{
    partial class BusinessForm
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
            this.button_create_business = new System.Windows.Forms.Button();
            this.label_business_actions = new System.Windows.Forms.Label();
            this.label_search_business = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_business_main_info = new System.Windows.Forms.CheckBox();
            this.button_business_search = new System.Windows.Forms.Button();
            this.textBox_search_business_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_business_locality = new System.Windows.Forms.Label();
            this.textBox_search_businesses_city = new System.Windows.Forms.TextBox();
            this.dataGridView_business = new System.Windows.Forms.DataGridView();
            this.button_delete_business = new System.Windows.Forms.Button();
            this.label_business_message = new System.Windows.Forms.Label();
            this.button_business_reset_search = new System.Windows.Forms.Button();
            this.checkBox_business_impressum = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_business)).BeginInit();
            this.SuspendLayout();
            // 
            // button_create_business
            // 
            this.button_create_business.Location = new System.Drawing.Point(13, 83);
            this.button_create_business.Name = "button_create_business";
            this.button_create_business.Size = new System.Drawing.Size(145, 23);
            this.button_create_business.TabIndex = 0;
            this.button_create_business.Text = "Partner aufnehmen";
            this.button_create_business.UseVisualStyleBackColor = true;
            this.button_create_business.Click += new System.EventHandler(this.button_create_business_Click);
            // 
            // label_business_actions
            // 
            this.label_business_actions.AutoSize = true;
            this.label_business_actions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_business_actions.Location = new System.Drawing.Point(26, 29);
            this.label_business_actions.Name = "label_business_actions";
            this.label_business_actions.Size = new System.Drawing.Size(120, 31);
            this.label_business_actions.TabIndex = 1;
            this.label_business_actions.Text = "Aktionen";
            // 
            // label_search_business
            // 
            this.label_search_business.AutoSize = true;
            this.label_search_business.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search_business.Location = new System.Drawing.Point(194, 29);
            this.label_search_business.Name = "label_search_business";
            this.label_search_business.Size = new System.Drawing.Size(91, 31);
            this.label_search_business.TabIndex = 2;
            this.label_search_business.Text = "Suche";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(757, 2);
            this.label1.TabIndex = 3;
            // 
            // checkBox_business_main_info
            // 
            this.checkBox_business_main_info.AutoSize = true;
            this.checkBox_business_main_info.Location = new System.Drawing.Point(386, 85);
            this.checkBox_business_main_info.Name = "checkBox_business_main_info";
            this.checkBox_business_main_info.Size = new System.Drawing.Size(102, 17);
            this.checkBox_business_main_info.TabIndex = 4;
            this.checkBox_business_main_info.Text = "allgemeine Infos";
            this.checkBox_business_main_info.UseVisualStyleBackColor = true;
            // 
            // button_business_search
            // 
            this.button_business_search.Location = new System.Drawing.Point(511, 121);
            this.button_business_search.Name = "button_business_search";
            this.button_business_search.Size = new System.Drawing.Size(84, 23);
            this.button_business_search.TabIndex = 5;
            this.button_business_search.Text = "suchen";
            this.button_business_search.UseVisualStyleBackColor = true;
            this.button_business_search.Click += new System.EventHandler(this.button_business_search_Click);
            // 
            // textBox_search_business_name
            // 
            this.textBox_search_business_name.Location = new System.Drawing.Point(241, 83);
            this.textBox_search_business_name.Name = "textBox_search_business_name";
            this.textBox_search_business_name.Size = new System.Drawing.Size(129, 20);
            this.textBox_search_business_name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // label_business_locality
            // 
            this.label_business_locality.AutoSize = true;
            this.label_business_locality.Location = new System.Drawing.Point(197, 127);
            this.label_business_locality.Name = "label_business_locality";
            this.label_business_locality.Size = new System.Drawing.Size(35, 13);
            this.label_business_locality.TabIndex = 8;
            this.label_business_locality.Text = "Stadt:";
            // 
            // textBox_search_businesses_city
            // 
            this.textBox_search_businesses_city.Location = new System.Drawing.Point(241, 124);
            this.textBox_search_businesses_city.Name = "textBox_search_businesses_city";
            this.textBox_search_businesses_city.Size = new System.Drawing.Size(129, 20);
            this.textBox_search_businesses_city.TabIndex = 9;
            // 
            // dataGridView_business
            // 
            this.dataGridView_business.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_business.Location = new System.Drawing.Point(200, 170);
            this.dataGridView_business.Name = "dataGridView_business";
            this.dataGridView_business.Size = new System.Drawing.Size(569, 228);
            this.dataGridView_business.TabIndex = 10;
            // 
            // button_delete_business
            // 
            this.button_delete_business.Location = new System.Drawing.Point(12, 121);
            this.button_delete_business.Name = "button_delete_business";
            this.button_delete_business.Size = new System.Drawing.Size(144, 23);
            this.button_delete_business.TabIndex = 11;
            this.button_delete_business.Text = "Partner entfernen";
            this.button_delete_business.UseVisualStyleBackColor = true;
            // 
            // label_business_message
            // 
            this.label_business_message.AutoSize = true;
            this.label_business_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_business_message.Location = new System.Drawing.Point(505, 29);
            this.label_business_message.Name = "label_business_message";
            this.label_business_message.Size = new System.Drawing.Size(125, 31);
            this.label_business_message.TabIndex = 12;
            this.label_business_message.Text = "Warten...";
            // 
            // button_business_reset_search
            // 
            this.button_business_reset_search.Location = new System.Drawing.Point(511, 83);
            this.button_business_reset_search.Name = "button_business_reset_search";
            this.button_business_reset_search.Size = new System.Drawing.Size(84, 23);
            this.button_business_reset_search.TabIndex = 13;
            this.button_business_reset_search.Text = "Zurücksetzen";
            this.button_business_reset_search.UseVisualStyleBackColor = true;
            // 
            // checkBox_business_impressum
            // 
            this.checkBox_business_impressum.AutoSize = true;
            this.checkBox_business_impressum.Location = new System.Drawing.Point(386, 123);
            this.checkBox_business_impressum.Name = "checkBox_business_impressum";
            this.checkBox_business_impressum.Size = new System.Drawing.Size(76, 17);
            this.checkBox_business_impressum.TabIndex = 14;
            this.checkBox_business_impressum.Text = "Impressum";
            this.checkBox_business_impressum.UseVisualStyleBackColor = true;
            // 
            // BusinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_business_impressum);
            this.Controls.Add(this.button_business_reset_search);
            this.Controls.Add(this.label_business_message);
            this.Controls.Add(this.button_delete_business);
            this.Controls.Add(this.dataGridView_business);
            this.Controls.Add(this.textBox_search_businesses_city);
            this.Controls.Add(this.label_business_locality);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_search_business_name);
            this.Controls.Add(this.button_business_search);
            this.Controls.Add(this.checkBox_business_main_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_search_business);
            this.Controls.Add(this.label_business_actions);
            this.Controls.Add(this.button_create_business);
            this.Name = "BusinessForm";
            this.Text = "Gewerbe-Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_business)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_create_business;
        private System.Windows.Forms.Label label_business_actions;
        private System.Windows.Forms.Label label_search_business;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_business_main_info;
        private System.Windows.Forms.Button button_business_search;
        private System.Windows.Forms.TextBox textBox_search_business_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_business_locality;
        private System.Windows.Forms.TextBox textBox_search_businesses_city;
        private System.Windows.Forms.DataGridView dataGridView_business;
        private System.Windows.Forms.Button button_delete_business;
        private System.Windows.Forms.Label label_business_message;
        private System.Windows.Forms.Button button_business_reset_search;
        private System.Windows.Forms.CheckBox checkBox_business_impressum;
    }
}