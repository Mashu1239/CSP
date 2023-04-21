using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Gen
{
    public partial class Form1 : Form
    {
        private readonly RandomNumberGenerator rng = RandomNumberGenerator.Create();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int TF;
            bool MaleLitery = checkBox1.Checked;
            bool DuzeLitery = checkBox2.Checked;
            bool Liczby = checkBox3.Checked;
            bool Symbole = checkBox4.Checked;

            string Znaki = "";
            if (MaleLitery) Znaki += "abcdefghijklmnopqrstuvwxyz";
            if (DuzeLitery) Znaki += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (Liczby) Znaki += "0123456789";
            if (Symbole) Znaki += "!@#$%^&*()_+-=[]{}\\|;:'\",.<>/?";
            
            if (Znaki.Length == 0)
            {
                MessageBox.Show("Musisz wybrac minimum 1 tym wartosci do hasla.");
                return;
            }
            if (int.TryParse(textBox2.Text, out TF))
            {
                int Dlugosc = int.Parse(textBox2.Text);

                byte[] bytes = new byte[Dlugosc * 4];
                rng.GetBytes(bytes);
                string Password = "";
                for (int i = 0; i < Dlugosc; i++)
                {
                    uint value = BitConverter.ToUInt32(bytes, i * 4); //uint bez ujemnych wartosci
                    int index = (int)(value % (uint)Znaki.Length);
                    Password += Znaki[index];
                }

                textBox1.Text = Password;
            }
            else
            {
                MessageBox.Show("Wpisz liczbe!");
            }
        }
    }
}
