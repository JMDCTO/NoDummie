using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoDummie
{
    public partial class MainForm : Form
    {
        string baseUrl = "http://192.168.2.103:3000/v1";

        public MainForm()
        {
            InitializeComponent();
            loadMainInfo();
        }

        private void loadMainInfo()
        {
            string method = "GET_USER_COUNT";

            string requestUrl = baseUrl + "/intern/search/user";
            var httpWebRequest = WebRequest.Create(requestUrl);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"method\":\"" + method + "\"}";
                streamWriter.Write(json);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                Console.WriteLine(responseText);
            }
        }

        private void button_search_user_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }

        private void button_search_business_Click(object sender, EventArgs e)
        {
            BusinessForm businessForm = new BusinessForm();
            businessForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.Show();
        }
    }
}
