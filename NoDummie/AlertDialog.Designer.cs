namespace NoDummie
{
    partial class AlertDialog
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
            this.label_alert_dialog = new System.Windows.Forms.Label();
            this.button_alert_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_alert_dialog
            // 
            this.label_alert_dialog.AutoSize = true;
            this.label_alert_dialog.Location = new System.Drawing.Point(83, 70);
            this.label_alert_dialog.Name = "label_alert_dialog";
            this.label_alert_dialog.Size = new System.Drawing.Size(35, 13);
            this.label_alert_dialog.TabIndex = 0;
            this.label_alert_dialog.Text = "label1";
            // 
            // button_alert_close
            // 
            this.button_alert_close.Location = new System.Drawing.Point(153, 121);
            this.button_alert_close.Name = "button_alert_close";
            this.button_alert_close.Size = new System.Drawing.Size(75, 23);
            this.button_alert_close.TabIndex = 1;
            this.button_alert_close.Text = "schließen";
            this.button_alert_close.UseVisualStyleBackColor = true;
            this.button_alert_close.Click += new System.EventHandler(this.button_alert_close_Click);
            // 
            // AlertDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(391, 227);
            this.Controls.Add(this.button_alert_close);
            this.Controls.Add(this.label_alert_dialog);
            this.Name = "AlertDialog";
            this.Text = "Fehler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_alert_dialog;
        private System.Windows.Forms.Button button_alert_close;
    }
}