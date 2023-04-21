using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            listBox1.Items.Clear();
            int TF;
            if (int.TryParse(textBox1.Text, out TF) && comboBox1.SelectedIndex >= 0)
            {

                //Parse(string to int)
                int Oczka = int.Parse(comboBox1.SelectedItem.ToString());
                int Ilosc = int.Parse(textBox1.Text);


                Random Random = new Random();

                for (int i = 0; i < Ilosc; i++)
                {
                    int Wynik = Random.Next(1, Oczka + 1);
                    listBox1.Items.Add(Wynik);
                }
            }
            else if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Nie podales ilosci rzutow");
            }
            else if (comboBox1.SelectedIndex >= 0)
            {
                MessageBox.Show("Podaj liczbe ;)");
            }
            else if (comboBox1.SelectedIndex >= 0 && textBox1.Text.Length == 0)
            {
                MessageBox.Show("Podaj dane");
            }
            else
            {
                MessageBox.Show("Wybierz ilosc oczek");
            }
        }
    }
}
