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
    public partial class DetailsInterface : Form
    {
        public OrderDetails orderDetails {  get; set; }
        public DetailsInterface(OrderDetails orderDetails)
        {
            InitializeComponent();
            this.orderDetails = orderDetails;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            orderDetails.Goods.Name = textBox1.Text;
            orderDetails.Num = int.Parse(textBox2.Text);
            Close();

        }
    }
}
