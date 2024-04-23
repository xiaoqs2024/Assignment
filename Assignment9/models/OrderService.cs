using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    //订单服务
    public class OrderService
    {
        public List<Order> orders;
        public OrderService()
        {
            orders = new List<Order>();
        }

        //添加订单
        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
                throw new ApplicationException($"添加错误: 订单{order.Id} 已经存在了!");
            orders.Add(order);
        }

        //删除订单
        public void DeleteOrder(int id)
        {
            Order order = orders.Where(o => o.Id == id).FirstOrDefault();
            if (order != null)
                orders.Remove(order);
        }
        //修改订单
        public void ChangeOrder(Order newOrder)
        {
            Order order = orders.Where(o => o.Id == newOrder.Id).FirstOrDefault();
            if(order != null)
            {
                orders.Remove(order);
                orders.Add(newOrder);
            }
        }
        public Order ConsultOrderById(int id)
        {
            return orders.Where(o => o.Id == id).FirstOrDefault();
        }
        public List<Order> ConsultOrderByCustomerId(int customerId)
        {
            //LINQ语句
            var orderlist = from result in orders
                            where result.Customer.Id == customerId
                            select result;
            return (List<Order>)orderlist;
        }

        //排序
        public List<Order> SortsOrders()
        {
            var orderlist = from result in orders
                        orderby result.Id
                        select result;
            return (List<Order>)orderlist;
        }
    }
}
