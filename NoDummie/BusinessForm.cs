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
    public partial class BusinessForm : Form
    {
        string baseUrl = "http://192.168.2.103:3000/v1";

        public BusinessForm()
        {
            InitializeComponent();
        }

        private void button_create_business_Click(object sender, EventArgs e)
        {
            CreateBusinessForm createBusinessForm = new CreateBusinessForm();
            createBusinessForm.Show();
        }

        private void button_business_search_Click(object sender, EventArgs e)
        {
            if(textBox_search_business_name.Text == "")
            {
                if(textBox_search_businesses_city.Text != "")
                {
                    searchBusinessByCity();
                }
            } else
            {
                searchBusinessesByName();
            }
        }

        private void searchBusinessesByName()
        {
            string method = "GET_PARTNERS_BY_NAME";
            string name = textBox_search_business_name.Text;
            string requestUrl = baseUrl + "/business";
            var httpWebRequest = WebRequest.Create(requestUrl);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"method\":\"" + method + "\"," +
                               "\"name\":\"" + name + "\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                Console.WriteLine(responseText);

                Partners partners = JsonConvert.DeserializeObject<Partners>(responseText);

                if (partners.partners != null)
                {
                    fillUpGridView(partners);
                }
            }
        }

        private void searchBusinessByCity()
        {
            string method = "GET_PARTNERS";
            string city = textBox_search_businesses_city.Text;
            string requestUrl = baseUrl + "/business";
            var httpWebRequest = WebRequest.Create(requestUrl);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"method\":\"" + method + "\"," +
                               "\"city\":\"" + city + "\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                Console.WriteLine(responseText);

                Partners partners = JsonConvert.DeserializeObject<Partners>(responseText);

                if(partners.partners != null)
                {
                    fillUpGridView(partners);
                }
            }
        }

        private void fillUpGridView(Partners partners)
        {
            dataGridView_business.DataSource = partners.partners;
        }
    }
}
