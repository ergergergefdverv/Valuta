using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valuta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "=>"; // змінюємо напрямок стрілки
            textBox3.Enabled = false; // блокуємо поле textBox3
            textBox4.Enabled = true; // активуємо поле textBox4
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "<="; // змінюємо напрямок стрілки
            textBox3.Enabled = true; // блокуємо поле textBox3
            textBox4.Enabled = false; // активуємо поле textBox4
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kurs1, kurs2, suma, sum_out;
            kurs1 = double.Parse(textBox1.Text);
            kurs2 = double.Parse(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                textBox4.Enabled = true;
                suma = double.Parse(textBox3.Text);
                sum_out = suma * kurs2;
                textBox4.Text = sum_out.ToString();
            }
            else
            {
                textBox4.Enabled = true;
                suma = double.Parse(textBox3.Text);
                sum_out = suma * kurs1;
                textBox4.Text = sum_out.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
