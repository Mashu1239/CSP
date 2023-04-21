using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RejestCzasuPracy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Pocz = Convert.ToDateTime(textBox2.Text);
            DateTime Kon = Convert.ToDateTime(textBox3.Text);
            TimeSpan Czas = Kon.Subtract(Pocz);
            listBox1.Items.Add(textBox1.Text + " Wykonal: " + textBox4.Text + " zajelo mu to: " + Czas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
