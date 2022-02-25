using Newtonsoft.Json;
using NoDummie.models;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace NoDummie
{
    public partial class UserForm : Form
    {
        string baseUrl = "http://192.168.2.103:3000/v1/intern/search";
        Rows users = new Rows();

        public UserForm()
        {
            InitializeComponent();
        }

        private void button_search_trigger_Click(object sender, EventArgs e)
        {
            string alias = textBox_search_alias.Text;
            string email = textBox_search_email.Text;
            string date = textBox_search_date.Text;

            if(alias == null && email == null)
            {

            } else {

                if(alias.Equals(""))
                {
                    if (date.Equals(""))
                    {
                        searchWithEmail();
                    } else
                    {
                        searchWithEmailAndDate();
                    }
                } else
                {
                    if (date.Equals(""))
                    {
                        searchWithAlias();
                    } else
                    {
                        searchWithAliasAndDate();
                    }
                }
            }
        }

        private void searchWithAliasAndDate()
        {
            string alias = textBox_search_alias.Text;
            string date = textBox_search_date.Text;
            string method = "ALIAS_DATE";

            string requestUrl = baseUrl + "/user";
            var httpWebRequest = WebRequest.Create(requestUrl);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"method\":\"" + method + "\"," +
                               "\"alias\":\"" + alias + "\"," +
                               "\"date\":\"" + date + "\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                Console.WriteLine(responseText);
                users = JsonConvert.DeserializeObject<Rows>(responseText);

                if (users.rows != null)
                {

                    fillUpGridView(users);
                    updateUIComponents(true, users.rows.Count);
                } 
                else
                {
                    updateUIComponents(false, 0);
                }
            }
        }

        private void searchWithEmailAndDate()
        {   
            string email = textBox_search_email.Text;
            string date = textBox_search_date.Text;
            string method = "EMAIL_DATE";

            string requestUrl = baseUrl + "/user";
            var httpWebRequest = WebRequest.Create(requestUrl);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"method\":\"" + method + "\"," +
                               "\"email\":\"" + email + "\"," + 
                               "\"date\":\"" + date + "\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();

                Console.WriteLine(responseText);
                users = JsonConvert.DeserializeObject<Rows>(responseText);

                if (users.rows != null)
                {

                    fillUpGridView(users);
                    updateUIComponents(true, users.rows.Count);
                }
                else
                {
                    updateUIComponents(false, 0);
                }
            }
        }

        private void searchWithEmail()
        {
            string email = textBox_search_email.Text;
            string method = "EMAIL";

            string requestUrl = baseUrl + "/user";
            var httpWebRequest = WebRequest.Create(requestUrl);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"method\":\"" + method + "\"," +
                                "\"email\":\"" + email + "\"}"; 

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                Console.WriteLine(responseText);

                users = JsonConvert.DeserializeObject<Rows>(responseText);

                Console.WriteLine(users.rows);

                if (users.rows != null)
                {

                    fillUpGridView(users);
                    updateUIComponents(true, users.rows.Count);
                }
                else
                {
                    updateUIComponents(false, 0);
                }
            }
        }

        private void searchWithAlias()
        {
            string alias = textBox_search_alias.Text;
            string method = "ALIAS";

            string requestUrl = baseUrl + "/user";
            var httpWebRequest = WebRequest.Create(requestUrl);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"method\":\"" + method + "\"," +
                                 "\"alias\":\"" + alias + "\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                Console.WriteLine(responseText);

                users = JsonConvert.DeserializeObject<Rows>(responseText);

                if (users.rows != null)
                {

                    fillUpGridView(users);
                    updateUIComponents(true, users.rows.Count);
                }
                else
                {
                    updateUIComponents(false, 0);
                }
            }
        }

        private void fillUpGridView(Rows data)
        {
            dataGridView_users.DataSource = data.rows;
        }
       
        private void updateUIComponents(bool successful, int amount)
        {
            if (successful)
            {
                this.label_num_results.Text = amount.ToString();
                this.label_num_results.ForeColor = Color.Green;
                this.label_response_type.Text = "SUCCESS";
                this.label_response_type.ForeColor = Color.Green;
            }
            else
            {
                this.label_num_results.Text = amount.ToString();
                this.label_num_results.ForeColor = Color.Red;
                this.label_response_type.Text = "FAILED";
                this.label_response_type.ForeColor = Color.Red;

                this.dataGridView_users.DataSource = null;
            }
        }

        private void button_search_user_reset_Click(object sender, EventArgs e)
        {   
            //reset UI
            this.label_num_results.Text = "0";
            this.label_num_results.ForeColor = Color.Turquoise;
            this.label_response_type.Text = "WAITING";
            this.label_response_type.ForeColor = Color.Turquoise;

            //reset textboxes

            this.textBox_search_alias.Text = "";
            this.textBox_search_date.Text = "";
            this.textBox_search_email.Text = "";

            //reset data grid
            this.dataGridView_users.DataSource = null;
        }

        private void button_open_userinfo_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = this.dataGridView_users.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount == 6)
            {
                string email = users.rows[dataGridView_users.SelectedCells[1].RowIndex].email;
                string id = users.rows[dataGridView_users.SelectedCells[1].RowIndex].Id;
                string alias = users.rows[dataGridView_users.SelectedCells[1].RowIndex].alias;
                string password = users.rows[dataGridView_users.SelectedCells[1].RowIndex].password;
                string date = users.rows[dataGridView_users.SelectedCells[1].RowIndex].date;
                string premium = users.rows[dataGridView_users.SelectedCells[1].RowIndex].premium;

                User user = new User(id, alias, email, password, date, premium);

                DetailUserForm detailUserForm = new DetailUserForm(user);
                detailUserForm.Text = "User: " + user.alias;
                detailUserForm.Show();
            }
        }
    }
}
