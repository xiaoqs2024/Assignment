using Assignment5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class AddOrderInterface : Form
    {
        public AddOrderInterface()
        {
            InitializeComponent();
        }
        public Order order = new Order();
        public bool flag = false;

        //确定
        private void button1_Click(object sender, EventArgs e)
        {
            List<OrderDetails> details = new List<OrderDetails>();
            if (textBox9.Text != "" && textBox14.Text != "" && textBox1.Text != "")
            { details.Add(new OrderDetails(new Goods("001", textBox9.Text, int.Parse(textBox14.Text)), int.Parse(textBox1.Text))); }
            if (textBox10.Text != "" && textBox2.Text != "" && textBox15.Text != "")
            { details.Add(new OrderDetails(new Goods("001", textBox10.Text, int.Parse(textBox2.Text)), int.Parse(textBox15.Text))); }
            if (textBox11.Text != "" && textBox3.Text != "" && textBox16.Text != "")
            { details.Add(new OrderDetails(new Goods("001", textBox11.Text, int.Parse(textBox3.Text)), int.Parse(textBox16.Text))); }
            if (textBox12.Text != "" && textBox4.Text != "" && textBox17.Text != "")
            { details.Add(new OrderDetails(new Goods("001", textBox12.Text, int.Parse(textBox4.Text)), int.Parse(textBox17.Text))); }

            String message = "";
            if (details == null)
            {
                message = "注意：未填写商品";
            }
            else if(textBox6.Text == "")
            {
                message = "注意：未填写订单ID";
            }
            else if (textBox7.Text == "")
            {
                message = "注意：未填写顾客ID";
            }
            else if (textBox8.Text == "")
            {
                message = "注意：未填写客户名";
            }
            else
            {
                message = "订单添加成功！";
                order.Id = textBox6.Text;
                order.Customer.Id = textBox7.Text;
                order.Customer.Name = textBox8.Text;
                order.Details = details;

                flag = true;
                this.Close();
            }
            MessageBox.Show(message);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        //取消
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
