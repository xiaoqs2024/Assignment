using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    //订单服务
    public class OrderService : Order
    {
        public List<Order> orders = new List<Order>();
        //添加订单
        public void AddOrder(string id, Customer customer, List<OrderDetails> details)
        {
            Order order = new Order(id,customer,details);
            foreach (Order ExistOrder in orders)
            {
                if(ExistOrder.Equals(order))
                {
                    Console.WriteLine("The order is already existing!");
                    break;
                }else if(ExistOrder.Id == Id && !ExistOrder.Equals(order))
                {
                    Console.WriteLine("The order number is already existing!");
                    break;
                }
            }
            orders.Add(order);

        }

        //删除订单
        public void DeleteOrder(string id, List<Order> orders)
        {
            try
            {
                //用foreach报错
                for(int i = 0; i < orders.Count; i++)
                {
                    if (id.Equals(orders[i].Id))
                    {
                        orders.Remove(orders[i]);
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Fail to delete the order!");
            }
        }

        //修改订单
        public void ChangeOrder(string id, Order newOrder, List<Order> orders)
        {
            try
            {
                for (int i = 0; i < orders.Count; i++)
                {
                    if (id.Equals(orders[i].Id))
                    {
                        //删除 旧的 那段数据
                        orders.Remove(orders[i]);
                        //将新的 这段数据 插入到 指定位置
                        orders.Insert(i, newOrder);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Fail to change the order!");
            }
        }
        
        //通过订单号查询订单信息
        public List<Order> ConsultOrderById(String id, List<Order> orders)
        {
            //LINQ语句
            var orderlist = from result in orders
                        where result.Id == id
                        select result;
            return (List<Order>)orderlist;
        }

        //通过顾客ID查询订单信息
        public List<Order> ConsultOrderByCustomerId(String customerId, List<Order> orders)
        {
            //LINQ语句
            var orderlist = from result in orders
                            where result.Customer.Id == customerId
                            select result;
            return (List<Order>)orderlist;
        }

        //排序
        public List<Order> SortsOrders(List<Order> orders)
        {
            var orderlist = from result in orders
                        orderby result.Id
                        select result;
            return (List<Order>)orderlist;
        }
    }
}
