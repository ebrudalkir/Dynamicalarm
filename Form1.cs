using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToShortDateString();
            textBox2.Text = DateTime.Now.ToShortTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text == DateTime.Now.ToShortDateString() && textBox2.Text == DateTime.Now.ToShortTimeString())
            {
                timer1.Stop();

                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath.ToString() + "\\Klasik-eski-telefon-sesi.wav";
                ses.SoundLocation = dizin;
                ses.Play();






   string[] sorular = { "Türkiye'nin başkenti neredir?", "cosx'in türevi nedir?", "İstanbul'da kaç üniversite vardır?", "Kayseri'nin plaka kodu nedir?", "Peri bacaları hangi ildedir?" };
                label3.Visible = true;
                textBox3.Visible = true;
                button3.Visible = true;
                Random rastgelesayi = new Random();
                int no = rastgelesayi.Next(0, sorular.Length);
                label3.Text = sorular[0].ToString();
                MessageBox.Show("alarm");
                
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] sorular = { "Türkiye'nin başkenti neredir?", "cosx'in türevi nedir?", "İstanbul'da kaç üniversite vardır?", "Kayseri'nin plaka kodu nedir?", "Peri bacaları hangi ildedir?" };
            Random rastgelesayi = new Random();
            int no = rastgelesayi.Next(0, sorular.Length);
            if (no == 0)
            {


                if (textBox3.Text == "ankara")
                {
                    button3.Text = "correct";
                    
                 
                }
                else
                {
                    button3.Text = "false!";
                }

            }
        }
    }
}
