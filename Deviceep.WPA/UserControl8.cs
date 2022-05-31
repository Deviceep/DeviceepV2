using Deviceep.WPA.JsonDTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Deviceep.WPA
{
    public partial class UserControl8 : UserControl
    {
        static HttpClient client = new HttpClient();
       
       
        public UserControl8()
        {
            client.BaseAddress = new Uri("https://localhost:44326/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
            //if (textBox1.Text == null)
            //{
              
            //}
            //else if(textBox1.Text != null)
            //{
            //    var a = comboBox1.SelectedIndex;
            //    //var a = comboBox1.SelectedIndex;
            //    var CourseID = a + 1;
            //    string rfid = textBox1.Text;

            //    System.Threading.Thread.Sleep(100);
            //    string url = "Attendance/RfidAttendance?";
            //    string param = $"CourseID={CourseID}&rfid={rfid}";
            //    string request = url + param;
            //    HttpContent content = new StringContent(param, Encoding.UTF8, "application/json");



            //    try
            //    {
            //        var response = client.PostAsync(request, content);
            //    }
            //    catch (HttpRequestException ex)
            //    {
            //        Console.WriteLine("Message :{0} ", ex.Message);
            //    }
                
            //    textBox1.Clear();
                
            //}
        }


        private void UserControl8_Load(object sender, EventArgs e)
        {
            
            //var response = client.GetStringAsync("Attendance");
            //var result = JsonConvert.DeserializeObject<List<RFIDJson>>(response.Result);
            //dataGridView1.DataSource = result;
            //dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            //dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            //dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            //dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Black;

            var response1 = client.GetStringAsync("Course");
            var result1 = JsonConvert.DeserializeObject<List<CoursesJson>>(response1.Result);

            foreach (var item in result1)
                {

                    comboBox1.Items.Add(item.CourseDescription.ToUpper());
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Combobox ders seçilecek bu ders'e ait atte gelecek, daha sonrasında her 10-*20 sani,yede bir güncellenir
             * RFID BURADA DİNLENMEYE BAŞLICAK  
             */
            //https://localhost:44326/api/Attendance/RfidAttendance?CourseID=7&rfid=1650930692
            #region RFID operation Controller
            if (textBox1.Text == null)
            {

            }
            else if (textBox1.Text != null)
            {
                var a = comboBox1.SelectedIndex;
                //var a = comboBox1.SelectedIndex;
                var CourseID = a + 1;
                string rfid = textBox1.Text;

                System.Threading.Thread.Sleep(100);
                string url = "Attendance/RfidAttendance?";
                string param = $"CourseID={CourseID}&rfid={rfid}";
                string request = url + param;
                HttpContent content = new StringContent(param, Encoding.UTF8, "application/json");



                try
                {
                    var response = client.PostAsync(request, content);
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine("Message :{0} ", ex.Message);
                }

                textBox1.Clear();

            }
            var response2 = client.GetStringAsync("Attendance");
            var result = JsonConvert.DeserializeObject<List<RFIDJson>>(response2.Result);

            dataGridView1.DataSource = result;
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
            #endregion

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //textBox1.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
