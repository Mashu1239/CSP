using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime DataAlarmu = dateTimePicker1.Value;

            if (DataAlarmu < DateTime.Now)
            {
                MessageBox.Show("Podana godzina alarmu jest już przeszła. Proszę podać przyszłą godzinę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            timer1.Enabled = true;
            timer1.Start();
            button1.Enabled = false;
            button3.Enabled = true;

            MessageBox.Show("Alarm został ustawiony na godzinę " + DataAlarmu.ToShortTimeString() + ".", "Potwierdzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime DataAlarmu = dateTimePicker1.Value;

            if (now.Hour == DataAlarmu.Hour && now.Minute == DataAlarmu.Minute && now.Date == DataAlarmu.Date)
            {
                MessageBox.Show("Budzik dzwoni!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Stop();
                button3.Enabled = false;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = false;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = true;
            button3.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
