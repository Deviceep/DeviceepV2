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
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region User Controller
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl81.Hide();
            userControl11.Show();
            userControl11.BringToFront();
            #endregion
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            #region User Controller1
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl81.Hide();
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region User Controller2
            userControl11.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl81.Hide();
            userControl21.Show();
            userControl21.BringToFront();
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region User Controller3
            userControl11.Hide();
            userControl21.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl31.Show();
            userControl31.BringToFront();
            #endregion
        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region User Controller4
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl41.Show();
            userControl41.BringToFront();
            #endregion
        }

        private void button5_Click(object sender, EventArgs e)
        {
            #region User Controller5
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl81.Hide();
            userControl51.Show();
            userControl51.BringToFront();
            #endregion
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region User Controller6
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl71.Hide();
            userControl81.Hide();
            userControl61.Show();
            userControl61.BringToFront();
            #endregion
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        static HttpClient client = new HttpClient();
        private void button8_Click(object sender, EventArgs e)
        {
            #region User Controller17
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl81.Hide();
            userControl71.Show();
            userControl71.BringToFront();
            #endregion
        }

        private void button9_Click(object sender, EventArgs e)
        {
            #region User Controller8
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
            userControl71.Hide();
            userControl81.Show();
            userControl81.BringToFront();
            #endregion
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
        }
    }
}
