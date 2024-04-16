using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment6
{
    public partial class From : Form
    {
        OrderService orderService = new OrderService();
        public String Keyword { get; set; }

        //初始化
        public void Init()
        {
            List<OrderDetails> details = new List<OrderDetails>();
            details.Add(new OrderDetails(1, new Goods(1, "apple", 5), 10));
            details.Add(new OrderDetails(1, new Goods(1, "apple", 5), 10));
            Order order1 = new Order(1, new Customer(1, "Jack"), details);
            orderService.AddOrder(order1);

            List<OrderDetails> details2 = new List<OrderDetails>();
            details2.Add(new OrderDetails(1, new Goods(1, "apple", 10), 10));
            Order order2 = new Order(2, new Customer(2, "Mary"), details2);
            orderService.AddOrder(order2);
        }

        //数据更新
        public void QueryAll()
        {
            bindingSource1.DataSource = orderService.orders;
            bindingSource1.ResetBindings(false);
        }

        public From()
        {
            InitializeComponent();
            Init();
            QueryAll();
            comboBox1.SelectedIndex = 0;
            textBox1.DataBindings.Add("Text", this, "Keyword");
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //新建订单
        private void button1_Click(object sender, EventArgs e)
        {
            ChangeOrderInterface changeOrderInterface = new ChangeOrderInterface(new Order(), orderService, true);
            changeOrderInterface.ShowDialog();
        }

        //查询
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        bindingSource1.DataSource = orderService.orders;
                        break;
                    case 1:
                        int id = Convert.ToInt32(Keyword);
                        Order order = orderService.ConsultOrderById(id);
                        if (order != null)
                        {
                            bindingSource1.DataSource = order;
                        }
                        break;
                    case 2:
                        id = Convert.ToInt32(Keyword);
                        List<Order> orderlist = orderService.ConsultOrderByCustomerId(id);
                        if (orderlist != null)
                        {
                            bindingSource1.DataSource = orderlist;
                        }
                        break;
                }
                bindingSource1.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //删除
        private void button3_Click(object sender, EventArgs e)
        {
            Order order = bindingSource1.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            DialogResult result = MessageBox.Show($"确认要删除Id为{order.Id}的订单吗？", "删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                orderService.DeleteOrder(order.Id);
                QueryAll();
            }
        }
        //修改
        private void button2_Click(object sender, EventArgs e)
        {
            ChangeOrderInterface changeOrderInterface = new ChangeOrderInterface(new Order(), orderService, false);
            changeOrderInterface.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
    
}
