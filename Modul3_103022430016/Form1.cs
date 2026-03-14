using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_103022430016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] comboBox_Option = { "Celcius", "Fahrenheit" , "Kelvin", "Reamur"};

            comboBox1.DataSource = comboBox_Option;
            comboBox2.DataSource = comboBox_Option.Clone();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
