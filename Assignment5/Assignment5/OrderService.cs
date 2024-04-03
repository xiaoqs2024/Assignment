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
        //添加订单
        public void AddOrder(string typeName, int heat, string orderNumber, string orderName, string customerName, int money, List<Order> orders)
        {
            Order order = new Order(typeName, heat, orderNumber, orderName, customerName, money);
            foreach (Order ExistOrder in orders)
            {
                if(ExistOrder.Equals(order))
                {
                    Console.WriteLine("The order is already existing!");
                    break;
                }else if(ExistOrder.orderNumber == orderNumber && !ExistOrder.Equals(order))
                {
                    Console.WriteLine("The order number is already existing!");
                    break;
                }
            }
            orders.Add(order);

        }

        //删除订单
        public void DeleteOrder(Order order, List<Order> orders)
        {
            try
            {
                //用foreach报错
                for(int i = 0; i < orders.Count; i++)
                {
                    if (order.Equals(orders[i]))
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
        public void ChangeOrder(Order order, Order newOrder, List<Order> orders)
        {
            try
            {
                for (int i = 0; i < orders.Count; i++)
                {
                    if (order.Equals(orders[i]))
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
        public void ConsultOrderByOrderNumber(String orderNumber, List<Order> orders)
        {
            //LINQ语句
            var orderlist = from result in orders
                        where result.orderNumber == orderNumber
                        select result;
            Console.WriteLine("您查询的订单如下：");
            foreach (var order in orderlist)
            {
                Console.WriteLine(order);
            }
        }

        //通过订单名查询订单信息，查询结果按订单金额排序
        public void ConsultOrderByOrderName(String orderName, List<Order> orders)
        {
            //LINQ语句
            var orderlist = from result in orders
                        where result.orderName == orderName
                        orderby result.money
                        select result;
            Console.WriteLine("您查询的订单如下：");
            foreach (var order in orderlist)
            {
                Console.WriteLine(order);
            }
        }

        //通过顾客名查询订单信息，查询结果按订单金额排序
        public void ConsultOrderByCustomerName(String customerName, List<Order> orders)
        {
            //LINQ语句
            var orderlist = from result in orders
                        where result.customerName == customerName
                        orderby result.money
                        select result;
            Console.WriteLine("您查询的订单如下：");
            foreach (var order in orderlist)
            {
                Console.WriteLine(order);
            }
        }

        //排序
        public void SortsOrders(List<Order> orders)
        {
            var orderlist = from result in orders
                        orderby result.orderNumber
                        select result;
            Console.WriteLine("全部订单如下：");
            foreach (var order in orderlist)
            {
                Console.WriteLine(order);
            }
        }
    }
}
