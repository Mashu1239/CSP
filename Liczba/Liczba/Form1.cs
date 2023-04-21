using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liczba
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int LosowyNumer;
        public Form1()
        {
            InitializeComponent();
            LosowyNumer = random.Next(1, 100);
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            int Try;

            if (int.TryParse(textBox1.Text, out Try))
            {
                if (Try == LosowyNumer)
                {
                    label1.Text = "Zgadles :>";
                }
                else if (Try < LosowyNumer)
                {
                    label1.Text = "Liczba jest większa niz " + Try;
                }
                else
                {
                    label1.Text = "Liczba jest mniejsza niz " + Try;
                }
            }
            else
            {
                MessageBox.Show("Wprowadź poprawną liczbę!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LosowyNumer = random.Next(1, 100);

            textBox1.Text = "";
            label1.Text = "";
        }
    }
}
