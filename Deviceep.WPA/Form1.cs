using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deviceep.WPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            #region User Controller
            if (textBox1.Text== "tur.musa@std.izu.edu.tr" || textBox1.Text== "yasin.ahmet@std.izu.edu.tr" || textBox1.Text=="cakar.umutcan@std.izu.edu.tr")
            {
                if (textBox2.Text == "12345")
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Wrong E-mail or Password!", "", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
            #endregion
        }
    }
}
