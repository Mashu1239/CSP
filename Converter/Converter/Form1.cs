using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Stopnie")
            {
                float Can1;
                if(textBox1.Text.Length >= 1 && float.TryParse(textBox1.Text, out Can1))
                {
                    float CF = float.Parse(textBox1.Text);
                    float CFOdp = 2 * CF + 32;
                    textBox2.Text = Convert.ToString(CFOdp);
                    
                }
                else if(textBox2.Text.Length >= 1 && float.TryParse(textBox2.Text, out Can1))
                {
                    float FC = float.Parse(textBox2.Text);
                    float FCOdp = FC /2 - 32;
                    textBox1.Text = Convert.ToString(FCOdp);
                }
                else
                {
                    MessageBox.Show("Podaj jedna wartosc");
                }
            }
            else if(comboBox1.Text == "Masa")
            {
                float Can1;
                if(textBox1.Text.Length >= 1 && float.TryParse(textBox1.Text, out Can1))
                {
                    float Kg = float.Parse(textBox1.Text);
                    float KgOdp = Kg * 1000;
                    textBox2.Text = Convert.ToString(KgOdp);
                }
                else if(textBox2.Text.Length >= 1 && float.TryParse(textBox2.Text, out Can1))
                {
                    float Gk = float.Parse(textBox2.Text);
                    float GkOdp = Gk / 1000;
                    textBox1.Text = Convert.ToString(GkOdp);
                }
                else
                {
                    MessageBox.Show("Podaj Jedna Wartosc");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Stopnie":
                    label1.Text = "Stopnie Cel";
                    label2.Text = "Faren";
                    break;
                case "Masa":
                    label1.Text = "Kilogramy";
                    label2.Text = "Gramy";
                    break;
                default:
                    label1.Text = "Wybierz opcję";
                    label2.Text = "Wybierz opcję";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
