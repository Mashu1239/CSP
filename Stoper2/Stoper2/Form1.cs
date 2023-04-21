using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stoper2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int milliseconds = 0;
        private int seconds = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            milliseconds++;
            if (milliseconds >= 100)
            {
                seconds++;
                milliseconds = 0;
            }
            UpdateTimeLabel();
        }
        private void UpdateTimeLabel()
        {
            label1.Text = seconds.ToString("00");
            label2.Text = milliseconds.ToString("00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            milliseconds = 0;
            seconds = 0;
            UpdateTimeLabel();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
