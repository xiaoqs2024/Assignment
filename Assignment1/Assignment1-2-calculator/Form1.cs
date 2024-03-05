using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0, c = 0;
            bool flag = true;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            if(textBox1.Text==null || textBox2.Text == null) { flag = false; }
            if (checkBox1.Checked)
            {
                c = a + b;
            }
            if(checkBox2.Checked)
            {
                c = a - b;
            }
            if (checkBox3.Checked)
            {
                c = a * b;
            }
            if(checkBox4.Checked)
            {
                if (b == 0) { flag = false; }
                else { c = a / b;}
            }
            if (flag == true) { MessageBox.Show("该式子的结果为" + c); }
            else { MessageBox.Show("您输入的数字有误！请重新输入！"); }
        }

  

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
