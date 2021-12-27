using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sinema s = new sinema();

        private void button1_Click(object sender, EventArgs e)
        {
            s.makskoltuk = s.koltuk = int.Parse(textBox1.Text);
            s.kasa = 0;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (s.koltuk!=0)
            {
                if (radioButton1.Checked)
                {
                    s.kasa = s.kasa + 10;
                }
                else
                {
                    s.kasa = s.kasa + 20;
                }
                s.koltuk = s.koltuk - 1;
            }
            else
            {
                MessageBox.Show("Hata! Bütün Koltuklar Doludur, Bilet Satılamaz");
            }


            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (s.koltuk < s.makskoltuk)
            {
                if (radioButton2.Checked)
                {
                    s.kasa = s.kasa - 10;
                }
                else
                {
                    s.kasa = s.kasa - 20;
                }
                s.koltuk = s.koltuk + 1;
            }
            else
            {
                MessageBox.Show("Hata! Bütün Koltuklar Doludur, Bilet Satılamaz");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = s.koltuk.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = s.kasa.ToString();
        }
    }
}
