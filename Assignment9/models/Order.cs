using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    //订单
    public class Order {
        public int Id { get; set; }//订单号
        public Customer Customer { get; set; }//顾客名
        public List<OrderDetails> Details { get; set; }//商品明细

        public Order() { }

        public Order(int id,Customer customer,List<OrderDetails> details)
        {
            this.Id = id;
            this.Customer = customer;
            this.Details = details;
        }

        //添加细则
        public void AddDetail(OrderDetails detail)
        {
            if (Details.Contains(detail))
            {return;}
            else { Details.Add(detail); }
        }
        //删除细则
        public void DeleteDetail(OrderDetails detail)
        {
            if (Details.Contains(detail))
            { return; }
            else { Details.Remove(detail); }
        }

        //重写Equals方法
        public override bool Equals(Object obj)
        {
            Order order = obj as Order;
            if (Id==order.Id &&
                Details==order.Details
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
            return "订单编号为" + Id + ",客户为" + Customer;
        }
    }
}