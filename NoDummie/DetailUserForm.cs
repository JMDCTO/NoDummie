using Newtonsoft.Json;
using NoDummie.models;
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
    public partial class DetailUserForm : Form
    {
        User user;
        string baseUrl = "http://192.168.2.103:3000/v1/intern/search";
        string internUrl = "http://192.168.2.103:3000/v1/users";
        public DetailUserForm(User user)
        {
            InitializeComponent();
            this.user = user;

            this.label_detailuser_id.Text = user.Id;
            this.label_detailuser_email.Text = user.email;
            this.label_detailuser_date.Text = user.date;
            this.label_detailuser_password.Text = user.password;
            this.label_detailuser_premium.Text = user.premium;

        }

        private void button_search_userdetails_Click(object sender, EventArgs e)
        {
            if(this.checkBox_search_loginstat.Checked)
            {
                requestUserLoginData();
            }

            if(this.checkBox_location.Checked)
            {
                requestUserLocationData();
            }

            if(this.checkBox_billing_address.Checked)
            {
                requestUserBillingAddress();
            }
        }

        private void requestUserBillingAddress()
        {
            string id = user.Id.ToString();
            string method = "GET_BILLING_ADDRESS";

            string requestUrl = internUrl + "/billingaddress";
            var httpWebRequest = WebRequest.Create(requestUrl);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"method\":\"" + method + "\"," +
                                "\"id\":\"" + id + "\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                Console.WriteLine(responseText);

                Address address = JsonConvert.DeserializeObject<Address>(responseText);

                Console.WriteLine(address.address);

                if (address.address != null)
                {
                    fillUpGridView(address);
                }
            }
        }

        private void requestUserLocationData()
        {
            string id = user.Id.ToString();
            string method = "ALL_LOCATION";

            string requestUrl = baseUrl + "/userlocation";
            var httpWebRequest = WebRequest.Create(requestUrl);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"method\":\"" + method + "\"," +
                                "\"id\":\"" + id + "\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                Console.WriteLine(responseText);

                Location locations = JsonConvert.DeserializeObject<Location>(responseText);

                Console.WriteLine(locations.location);

                if (locations.location != null)
                {
                    fillUpGridView(locations);
                }
            }
        }

        private void requestUserLoginData()
        {
            string id = user.Id.ToString();
            string method = "ALL_LOGIN";

            string requestUrl = baseUrl + "/userlogindata";
            var httpWebRequest = WebRequest.Create(requestUrl);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"method\":\"" + method + "\"," +
                                "\"id\":\"" + id + "\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                Console.WriteLine(responseText);

                UserLogins logins = JsonConvert.DeserializeObject<UserLogins>(responseText);

                Console.WriteLine(logins.userlogins);

                if (logins.userlogins != null)
                {

                    fillUpGridView(logins);
                }
            }
        }

        private void fillUpGridView(UserLogins data)
        {
            dataGridView_advanced_data.DataSource = data.userlogins;
        }
        private void fillUpGridView(Location data)
        {
            dataGridView_advanced_data.DataSource = data.location;
        }

        private void fillUpGridView(Address data)
        {
            dataGridView_advanced_data.DataSource = data.address;
        }

    }
}
