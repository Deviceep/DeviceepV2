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

namespace Deviceep.WPA
{
    public partial class UserControl5 : UserControl
    {
        static HttpClient client = new HttpClient();
        public UserControl5()
        {
            InitializeComponent();
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
            client.BaseAddress = new Uri("https://localhost:44326/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetStringAsync("Classroom");
            var result = JsonConvert.DeserializeObject<List<ClassroomJson>>(response.Result);
            dataGridView1.DataSource = result;

            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Black;
        }
    }
}
