using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment5
{
    //订单
    public class Order {
        public string Id { get; set; }//订单号
        public Customer Customer { get; set; }//顾客名
        public List<OrderDetails> Details { get; set; }//商品明细
        public int Money 
        {
            get => Details.Sum(item => item.money);
        }//订单金额

        public Order() { }

        public Order(string id,Customer customer,List<OrderDetails> details)
        {
            this.Id = id;
            this.Customer = customer;
            this.Details = details;
        }

        //重写Equals方法
        public override bool Equals(Object obj)
        {
            Order order = obj as Order;
            if (Id==order.Id &&
                Details==order.Details &&
                Money==order.Money
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //重写ToString方法
        public override string ToString()
        {
            return "订单编号为" + Id + ",客户为" + Customer + ",金额为" + Money;
        }
    }
}