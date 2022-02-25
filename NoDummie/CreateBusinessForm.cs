using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace NoDummie
{
    public partial class CreateBusinessForm : Form
    {
        string baseUrl = "http://192.168.2.103:3000/v1";
        bool imageIsSet = false;
        String pathToSelectedFile;
        private string offícialNameBusiness;

        public CreateBusinessForm()
        {
            InitializeComponent();
        }

        private void button_start_onboarding_Click(object sender, EventArgs e)
        {
           if(textBoxesFilled())
            {
                addBusinessToSystem();
                sendPicturesToDatabase();
                addBusinessExtraDataToSystem();

            }
            else
            {
                MessageBox.Show("Es sind nicht alle Daten vorhanden!");
            }
        }

        private void sendPicturesToDatabase()
        {
            string method = "ADD_BUSINESS_LOGO";

            string requestUrl = baseUrl + "/intern/business/logo";
            var httpWebRequest = WebRequest.Create(requestUrl);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";

            Image image = Image.FromFile(pathToSelectedFile);
            byte[] imageArr = imageToByteArray(image);
            //byte[] imageArray = System.IO.File.ReadAllBytes(pathToSelectedFile);
            string imageString = Convert.ToBase64String(imageArr);
            string name = textBox_onboarding_name_official.Text;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"method\":\"" + method + "\"," +
                               "\"official\":\"" + name + "\"," +
                               "\"image\":\"" + imageString + "\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                Console.WriteLine(responseText);
            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void addBusinessToSystem()
        {
            offícialNameBusiness = textBox_onboarding_name_official.Text;
            string alias = textBox_onboarding_alias.Text;
            string street = textBox_onboarding_street.Text;
            string housenumber = textBox_onboarding_housenumber.Text;
            string postalcode = textBox_onboarding_postalcode.Text;
            string city = textBox_onboarding_city.Text;
            string latitude = textBox_onboarding_latitude.Text;
            string longitude = textBox_onboarding_longitude.Text;
            string method = "CREATE_BUSINESS";

            string requestUrl = baseUrl + "/business";
            var httpWebRequest = WebRequest.Create(requestUrl);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"method\":\"" + method + "\"," +
                               "\"officialname\":\"" + offícialNameBusiness + "\"," +
                               "\"alias\":\"" + alias + "\"," +
                               "\"street\":\"" + street + "\"," +
                               "\"number\":\"" + housenumber + "\"," +
                               "\"postal\":\"" + postalcode + "\"," +
                               "\"city\":\"" + city + "\"," +
                               "\"latitude\":\"" + latitude + "\"," +
                               "\"longitude\":\"" + longitude + "\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                Console.WriteLine(responseText);
            }
        }

        private bool textBoxesFilled()
        {
            bool isAllFilled = true;

            if(textBox_onboarding_name_official.Text.Length == 0)
            {
                isAllFilled = false;
            }

            if(textBox_onboarding_alias.Text.Length == 0)
            {
                isAllFilled = false;
            }

            if(textBox_onboarding_street.Text.Length == 0)
            {
                isAllFilled = false;
            }

            if(textBox_onboarding_housenumber.Text.Length == 0)
            {
                isAllFilled = false;
            }

            if(textBox_onboarding_postalcode.Text.Length == 0)
            {
                isAllFilled = false;
            }

            if(textBox_onboarding_city.Text.Length == 0)
            {
                isAllFilled = false;
            }

            if(textBox_onboarding_latitude.Text.Length == 0)
            {
                isAllFilled = false;
            }

            if(textBox_onboarding_longitude.Text.Length == 0) 
            {
                isAllFilled = false; 
            }

            if(!imageIsSet)
            {
                isAllFilled = false;
            }

            return isAllFilled;
        }

        private void addBusinessExtraDataToSystem()
        {
            string officialContact = textBox_official_contact.Text;
            string emailContact = textBox_official_email.Text;
            string street;
            string city; 
            string houseNumber;
            string postal;

            if (!checkBox_same_adress.Checked)
            {
                street = textBox_official_street.Text;
                city = textBox_official_city.Text;
                houseNumber = textBox_officlai_houseNumber.Text;
                postal = textBox_official_postal.Text;

            } 
            else
            {
                street = textBox_onboarding_street.Text;
                houseNumber = textBox_onboarding_housenumber.Text;
                postal = textBox_onboarding_postalcode.Text;
                city = textBox_onboarding_city.Text;
            }

            string method = "ADD_EXTRA_DATA_BUSINESS";

            string requestUrl = baseUrl + "/business/impressum";
            var httpWebRequest = WebRequest.Create(requestUrl);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"method\":\"" + method + "\"," +
                               "\"officialnamebusiness\":\"" + offícialNameBusiness + "\"," +
                               "\"officialname\":\"" + officialContact + "\"," +
                               "\"email\":\"" + emailContact + "\"," +
                               "\"street\":\"" + street + "\"," +
                               "\"number\":\"" + houseNumber + "\"," +
                               "\"postal\":\"" + postal + "\"," +
                               "\"city\":\"" + city + "\"}";

                streamWriter.Write(json);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                Console.WriteLine(responseText);
            }
        }
        private void pictureBox_business_logo_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    pictureBox_business_logo.Image = Image.FromFile(filePath);
                    imageIsSet = true;
                    this.label_onboarding_pic_chosen.Text = filePath;
                    pathToSelectedFile = filePath;
                }
            }
        }
    }
}
