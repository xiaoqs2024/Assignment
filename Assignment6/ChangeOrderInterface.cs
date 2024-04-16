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
    public partial class ChangeOrderInterface : Form
    {
        private OrderService orderService;
        Order order;
        bool flag;
        public ChangeOrderInterface(Order order, OrderService orderService, bool flag)
        {
            InitializeComponent();
            this.order = order;
            this.orderService = orderService;
            this.flag = flag;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //添加明细
        private void button1_Click(object sender, EventArgs e)
        {
            DetailsInterface detailsInterface = new DetailsInterface(new OrderDetails());
            try
            {
                if (detailsInterface.ShowDialog() == DialogResult.OK)
                {
                    int index = 0;
                    if (order.Details.Count != 0)
                    {
                        index = order.Details.Max(i => i.Index) + 1;
                    }
                    detailsInterface.orderDetails.Index = index;
                    order.AddDetail(detailsInterface.orderDetails);
                }
                Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        //修改订单
        private void button2_Click(object sender, EventArgs e)
        {
            OrderDetails detail = bindingSource1.Current as OrderDetails;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单项进行修改");
                return;
            }
            DetailsInterface formDetailEdit = new DetailsInterface(detail);
            if (formDetailEdit.ShowDialog() == DialogResult.OK)
            {
                bindingSource1.ResetBindings(false);
            }
        }

        //删除订单
        private void button3_Click(object sender, EventArgs e)
        {
            OrderDetails detail = bindingSource1.Current as OrderDetails;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单项进行删除");
                return;
            }
            order.DeleteDetail(detail);
            bindingSource1.ResetBindings(false);
        }

        private void 保存_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag)
                {
                    orderService.AddOrder(order);
                }
                else
                {
                    orderService.ChangeOrder(order);
                }
                Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
        }
    }
}
