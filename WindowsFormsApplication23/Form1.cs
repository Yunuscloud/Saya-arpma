using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication23
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

        private void button2_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(textBox1.Text);
            if (sayı1 < 10) 
            {
                sayı1++;
            }
            textBox1.Text = sayı1.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1 = Convert.ToInt32(textBox1.Text);
            if (sayı1 > 0)
            {
                sayı1--;
            }
            textBox1.Text = sayı1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi1 = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add(i + "*" + textBox1.Text+ "=" + i * sayi1);
            }		
            
        }
    }
}
