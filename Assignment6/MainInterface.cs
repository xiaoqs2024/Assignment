using Assignment5;
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
        //初始两个订单信息
        static List<OrderDetails> details = new List<OrderDetails>()
        {
            new OrderDetails(new Goods("001", "apple", 5), 10),
            new OrderDetails(new Goods("002", "banana", 4), 3)
        };
        static Order order1 = new Order("001", new Customer("001", "Jack"), details);
        static List<OrderDetails> details2 = new List<OrderDetails>()
        {
            new OrderDetails(new Goods("001", "apple", 10), 10)
        };
        static Order order2 = new Order("002", new Customer("002", "Mary"), details2);

        //订单及服务
        public List<Order> orderList = new List<Order>() {order1,order2 };
        
        OrderService orderService = new OrderService();

        //订单展示
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataColumn col = new DataColumn();

        public From()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //订单表格
            
            col.AutoIncrement = true;
            col.AutoIncrementSeed = 1;
            col.AutoIncrementStep = 1;
            col.AllowDBNull = false;

            dt.Columns.Add("订单ID", typeof(string));
            dt.Columns.Add("顾客名", typeof(string));
            dt.Columns.Add("总价", typeof(int));

          
            dt2.Columns.Add("商品", typeof(string));
            dt2.Columns.Add("数量", typeof(int));
            dt2.Columns.Add("单价", typeof(int));

            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt2;
        }

        //订单信息展示
        private void Show(List<Order> resultList)
        {
            if (resultList == null)
            {
                MessageBox.Show("注意：没有相关订单信息！");
            }
            else
            {
               foreach(Order order in resultList)
               {
                    dt.Rows.Add(order.Id, typeof(string));
                    dt.Rows.Add(order.Customer.Name, typeof(string));
                    dt.Rows.Add(order.Money, typeof(int));

                    foreach(OrderDetails detail in order.Details)
                    {
                        dt2.Rows.Add(detail.goods.Id, typeof(string));
                        dt2.Rows.Add(detail.num, typeof(int));
                        dt2.Rows.Add(detail.goods.Price, typeof(int));
                    }
                    
               }
            }
        }
        //新建订单
        private void button1_Click(object sender, EventArgs e)
        {
            
            AddOrderInterface winform = new AddOrderInterface();
            winform.ShowDialog();
            if (winform.flag)
            {
                orderList.Add(winform.order);
            }
        }
        //订单ID查询
        private void button4_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text == "")
            {
                MessageBox.Show("注意：未输入订单ID");
            }
            else
            {
                List<Order> resultList = orderService.ConsultOrderById(textBox1.Text, orderList);
                Show(resultList);
            }

        }
        //客户ID查询
        private void button5_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "")
            {
                MessageBox.Show("注意：未输入顾客ID");
            }
            else
            {
                List<Order> resultList = orderService.ConsultOrderByCustomerId(textBox2.Text, orderList);
                Show(resultList);
            }
        }
        //删除
        /*
         * 老师，这两个功能还没有搞明白，几次写错都删了
         * 后续我会补充完整，再重新提交一次作业
         * 截止日期到了所以先交这一份
         */
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        //修改
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
    
}
