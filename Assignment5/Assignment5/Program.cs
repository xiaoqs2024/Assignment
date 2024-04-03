using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>() {
            new Order("computer",10, "001","huawei","Jack",3000)
            };
            OrderService ods = new OrderService();
            //添加订单
            Console.WriteLine("----------addorder-----------");
            ods.AddOrder("computer", 6, "002", "oppo", "Olivia", 8000, orders);
            ods.SortsOrders(orders);
            //删除订单
            Console.WriteLine("---------deleteorder---------");
            Order o = new Order("computer", 6, "002", "oppo", "Olivia", 8000);
            ods.DeleteOrder(o, orders);
            ods.SortsOrders(orders);
            //修改订单
            Console.WriteLine("---------changeorder---------");
            Order order1 = new Order("computer", 10, "001", "huawei", "Jack", 3000);
            Order order2 = new Order("computer", 10, "001", "huawei", "El", 3000);
            ods.ChangeOrder(order1, order2, orders);
            ods.SortsOrders(orders);
            //查询订单
            Console.WriteLine("---------sortorder----------");
            ods.ConsultOrderByOrderNumber("001", orders);
            ods.SortsOrders(orders);
        }
    }
}
