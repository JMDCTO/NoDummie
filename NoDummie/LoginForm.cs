using System;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NoDummie.models;

namespace NoDummie
{
    public partial class LoginForm : Form
    {

        string user = "dummie";
        string pw = "dummie";

        public LoginForm()
        {
            InitializeComponent();

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //Open Main Form here ! => thie will be the main UI
            //
            user = textBox_username.Text;//textBox_username.Text;
            pw = textBox_pw.Text;//textBox_pw.Text;

            if (validateUser(user) && validatePw(pw))
            {
                if (validateCredentials()) { 
                var mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
                }
            }
        }

        private bool validateUser(string username)
        {
            Console.WriteLine("Username Validation");
            return true;
        }

        private bool validatePw(string password)
        {
            Console.WriteLine("Password Validation");
            return true;
        }   

        private bool validateCredentials()
        {
            string requestUrl = "http://192.168.2.103:3000/v1/intern/users";
            var httpWebRequest = WebRequest.Create(requestUrl);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";
            
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"username\":\"" + user + "\"," +
                                "\"password\":\"" + pw + "\"}"; 

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();

                if (responseText.Contains("false"))
                {
                    AlertDialog alertDialog = new AlertDialog("Anmeldedaten falsch. Login fehlgeschlagen.");
                    alertDialog.Show(); 
                    return false;
                }
                else { 

                    Console.WriteLine(responseText);
                    return true;
                }
            }
        }

    }
}
