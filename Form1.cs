using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FOREACH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] dizi = new int[5];
        int indiz = 0;

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (indiz == 5)
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                int deger = Convert.ToInt16(textBox1.Text);
                dizi[indiz] = deger;
                listBox1.Items.Add(dizi[indiz].ToString());
                textBox1.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < dizi.Length; i++)
            {
                listBox1.Items.Add(dizi[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = dizi.Length - 1; i <= 0; i--)
            {
                listBox1.Items.Add(dizi[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = dizi.Length - 1; i >= 0; i--)
            {
                dizi[i] = 0;
            }
            textBox1.Enabled = true;
            button1.Enabled = true;
            textBox1.Focus();


        }
    }
}
