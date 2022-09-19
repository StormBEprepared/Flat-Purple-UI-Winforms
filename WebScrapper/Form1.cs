using CsvHelper;
using HtmlAgilityPack;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using HtmlAgilityPack;

namespace WebScrapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Hide();label1.Hide();label2.Hide();label3.Hide();label4.Hide();label5.Hide();label6.Hide();textBox1.Hide();textBox2.Hide();textBox3.Hide();textBox4.Hide();textBox5.Hide();textBox6.Hide();button5.Hide();
        }    

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Show();label2.Show();textBox1.Show();textBox2.Show();button5.Show();
            label3.Hide();label4.Hide();label5.Hide();label6.Hide();textBox3.Hide();textBox4.Hide();textBox5.Hide();textBox6.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Show();label2.Show();label3.Show();label4.Show();label5.Show();label6.Show();textBox1.Show();textBox2.Show();textBox3.Show();textBox4.Show();textBox5.Show();textBox6.Show();button5.Show();
        }
    }
}