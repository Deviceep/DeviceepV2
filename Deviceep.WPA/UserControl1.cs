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
using Deviceep.WPA.JsonDTO;

namespace Deviceep.WPA
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        static HttpClient client = new HttpClient();
        
        private void button1_Click(object sender, EventArgs e)
        {
            client.BaseAddress = new Uri("https://localhost:44326/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response1 = client.GetStringAsync(string.Format("User?id={0}", textBox1.Text));
            var result1 = JsonConvert.DeserializeObject<List<UserJson>>(response1.Result);
            dataGridView1.DataSource = result1;
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            


        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            client.BaseAddress = new Uri("https://localhost:44326/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetStringAsync("User");
            var result = JsonConvert.DeserializeObject<List<UserJson>>(response.Result);
            dataGridView1.DataSource = result;

            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Black;
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
