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
            if (radioButton1.Checked)
            {
                s.biletsatindirim = true;
            }
            else
            {
                s.biletsatindirim = false;
            }

            s.biletsat();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                s.biletiptalindirim = true;
            }
            else
            {
                s.biletiptalindirim = false;
            }

            s.biletiptalet();
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
