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
    public partial class CategoriesForm : Form
    {
        string baseUrl = "http://192.168.2.103:3000/v1";
        String pathToSelectedFile;
        bool imageIsSet = false;
        CategoryJSON categories;

        public CategoriesForm()
        {
            InitializeComponent();

            requestAvailableCategories();
        }

        private void requestAvailableCategories()
        {
                string method = "GET_CATEGORIES";

                string requestUrl = baseUrl + "/products/categories";
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

                    categories = JsonConvert.DeserializeObject<CategoryJSON>(responseText);
                    
                    if(categories != null)
                {
                    Console.WriteLine(categories.categories.Count);
                    fillUpSpinner();
                }
            }
        }

        private void fillUpSpinner()
        {
            string[] categoryTitles = new string[categories.categories.Count];

            for(int i = 0; i < categories.categories.Count; i++)
            {
                categoryTitles[i] = categories.categories[i].title;
            }

            comboBox_categories.Items.AddRange(categoryTitles);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
                    pictureBox1.Image = Image.FromFile(filePath);
                    imageIsSet = true;
                    this.label_selected_file.Text = filePath;
                    pathToSelectedFile = filePath;
                }
            }
        }

        private void checkBox_choose_category_CheckedChanged(object sender, EventArgs e)
        {
           if(checkBox_choose_category.Checked)
            {
                textBox_category_name.Enabled = true;
                richTextBox_cat_description.Enabled = true;

                if(checkBox_choose_tag.Checked)
                {
                    checkBox_choose_tag.Checked = false;
                }
                if(!button_finish_create_category.Enabled)
                {
                    button_finish_create_category.Enabled = true;
                }
            } 
            else
            {
                textBox_category_name.Enabled = false;
                richTextBox_cat_description.Enabled = false;

                if (button_finish_create_category.Enabled)
                {
                    button_finish_create_category.Enabled = false;
                }
            }
        }

        private void checkBox_choose_tag_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_choose_tag.Checked)
            {
                richTextBox_tag_description.Enabled = true;
                textBox_tag_name.Enabled = true;
                comboBox_categories.Enabled = true;

                if (checkBox_choose_category.Checked)
                {
                    checkBox_choose_category.Checked = false;
                }
                if (!button_finish_create_category.Enabled)
                {
                    button_finish_create_category.Enabled = true;
                }
            } 
            else
            {
                textBox_tag_name.Enabled = false;
                richTextBox_tag_description.Enabled = false;
                comboBox_categories.Enabled = false;

                if (button_finish_create_category.Enabled)
                {
                    button_finish_create_category.Enabled = false;
                }
            }
        }

        private void button_finish_create_category_Click(object sender, EventArgs e)
        {
            if (checkBox_choose_category.Checked && checkBox_choose_tag.Checked)
            {

            }
            else
            {
                if (checkBox_choose_category.Checked)
                {
                    if (checkAllElements(true))
                    {
                        addCategoryToSystem();
                    }
                    else
                    {
                        MessageBox.Show("Es sind nicht alle Daten vorhanden!");
                    }
                }

                if (checkBox_choose_tag.Checked)
                {
                    if (checkAllElements(false))
                    {
                        addTagToSystem();
                    }
                    else
                    {
                        MessageBox.Show("Es sind nicht alle Daten vorhanden!");
                    }
                }
            }
        }

        private void addTagToSystem()
        {
            string name = textBox_tag_name.Text;
            string description = richTextBox_tag_description.Text;
            int choosenIndex = comboBox_categories.SelectedIndex;
            Category category = categories.categories[choosenIndex];
            Console.WriteLine(category.title);

            int categoryId =  int.Parse(category.id);

            Image image = Image.FromFile(pathToSelectedFile);
            byte[] imageArr = imageToByteArray(image);
            string imageString = Convert.ToBase64String(imageArr);

            
            if (name.Length > 0 && description.Length > 0 && categoryId != 0)
            {
                string method = "CREATE_TAG";

                string requestUrl = baseUrl + "/products/categories/tags";
                var httpWebRequest = WebRequest.Create(requestUrl);
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = "application/json";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"method\":\"" + method + "\"," +
                                   "\"name\":\"" + name + "\"," +
                                   "\"description\":\"" + description + "\"," +
                                   "\"logo\":\"" + imageString + "\"," +
                                   "\"category\":\"" + categoryId + "\"}";

                    streamWriter.Write(json);
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    Console.WriteLine(responseText);
                }
            }
        }

        private void addCategoryToSystem()
        {
            string name = textBox_category_name.Text; 
            string description = richTextBox_cat_description.Text;

            Image image = Image.FromFile(pathToSelectedFile);
            byte[] imageArr = imageToByteArray(image);
            string imageString = Convert.ToBase64String(imageArr);

            if (name.Length > 0 && description.Length > 0)
            {
                string method = "CREATE_CATEGORY";

                string requestUrl = baseUrl + "/products/categories";
                var httpWebRequest = WebRequest.Create(requestUrl);
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = "application/json";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"method\":\"" + method + "\"," +
                                   "\"title\":\"" + name + "\"," +
                                   "\"description\":\"" + description + "\"," +
                                   "\"logo\":\"" + imageString + "\"}";

                    streamWriter.Write(json);
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    Console.WriteLine(responseText);
                }
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

        public bool checkAllElements(bool isCategory)
        {
            if (imageIsSet)
            {
                if (isCategory)
                {
                    if (textBox_category_name.Text.Length > 0)
                    {
                        if (richTextBox_cat_description.Text.Length > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                } 
                else
                {
                    if (textBox_tag_name.Text.Length > 0)
                    {
                        if (richTextBox_tag_description.Text.Length > 0)
                        {
                           if (comboBox_categories.SelectedText.Equals("--Kategorie--"))
                           {
                               return false;
                           }
                           return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }
    }
}
