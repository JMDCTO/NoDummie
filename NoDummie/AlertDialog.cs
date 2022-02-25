using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoDummie
{
    public partial class AlertDialog : Form
    {

        public string errMessage;

        public AlertDialog()
        {
            InitializeComponent();
        }

        public AlertDialog(string errMessage)
        {
            InitializeComponent();

            this.errMessage = errMessage;
            this.label_alert_dialog.Text = this.errMessage;
        }

        private void button_alert_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
