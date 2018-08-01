using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp;
            int q = 0;
            temp = textBox1.Text;
            int.TryParse(textBox2.Text, out q);
            if( String.Compare( temp, "Yonex") == 0 )
            {
                //res = 1000 * q;
                textBox3.Text = (2000 * q).ToString();
            }
            else if(String.Compare(temp, "2Silvers") == 0)
            {
                textBox3.Text = (1000 * q).ToString();
            }
            else if(String.Compare(temp, "Cosco") == 0)
            {
                textBox3.Text = (800 * q).ToString();
            }
            else
            {
                textBox1.Text = "Enter Valid Brand";
                textBox2.Text = "Enter Valid Quantity";
            }
        }
    }
}
