using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    //订单
    public class Order : OrderDetails {
        public string orderNumber { get; set; }//订单号
        public string orderName { get; set; }//商品名称
        public string customerName { get; set; }//顾客名
        public int money { get; set; }//订单金额

        public Order() { }

        public Order(string typeName,int heat,
            string orderNumber, string orderName, string customerName, int money)
        {
            this.typeName = typeName;
            this.heat = heat;

            this.orderNumber = orderNumber;
            this.orderName = orderName;
            this.customerName = customerName;
            this.money = money;

        }
        //重写Equals方法
        public override bool Equals(Object obj)
        {
            Order order = obj as Order;
            if (orderNumber == order.orderNumber &&
                orderName == order.orderName &&
                customerName == order.customerName &&
                money == order.money &&
                typeName == order.typeName &&
                heat == order.heat
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
            return "该类商品的类型为" + typeName + ",该类商品的销售热度为" + heat
                +",订单编号为" + orderNumber + ",商品名称为" + orderName
                + ",客户为" + customerName + ",金额为" + money+"。";
        }
    }
}