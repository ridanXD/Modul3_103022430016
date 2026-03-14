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

        private double ConvertTempature(double value, string fromUnit, string toUnit)
        {
            double result = value;
            if (fromUnit == "Fahrenheit")
                result = (value - 32) * 5 / 9;
            else if (fromUnit == "Kelvin")
                result = value - 273.15;
            else if (fromUnit == "Reamur")
                result = value * 5 / 4;
            if (toUnit == "Fahrenheit")
                result = (result * 9 / 5) + 32;
            else if (toUnit == "Kelvin")
                result = result + 273.15;
            else if (toUnit == "Reamur")
                result = result * 4 / 5;
            return result;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }
            double value = Convert.ToDouble(textBox1.Text);
                
            String fromUnit = comboBox1.SelectedItem.ToString();
            String toUnit = comboBox2.SelectedItem.ToString();

            double result = ConvertTempature(value, fromUnit, toUnit);

            textBox2.Text = result.ToString("F2");
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
