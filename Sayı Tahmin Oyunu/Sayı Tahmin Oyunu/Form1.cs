using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int zaman = 5;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label2.Text = zaman.ToString();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            zaman--;
            label2.Text = zaman.ToString();

            if (zaman==0)
            {
                
                timer1.Enabled = false;
                Random rastgele = new Random();
                int sayı;
                sayı = rastgele.Next(0, 10);

                int metin = Convert.ToInt16(textBox1.Text);

                if (metin == sayı)
                {
                    MessageBox.Show("Tebrikler dogru bildiniz");
                }
                else
                {
                    MessageBox.Show("Canın sağolsun bulamadın,tekrar deneyin.Tuttuğum sayı" + " " + sayı);
                }
                zaman = Convert.ToInt16("5");            
                timer1.Start();
                timer1.Stop();
                
            }
        }
    }
}
