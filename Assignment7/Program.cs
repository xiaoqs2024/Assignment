using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            //添加订单
            int newOrderId = 0;
            int newOrderDetailId = 0;
            using (var context = new OrderContext())
            {
                var customer = new Customer { CustomerId = 1,Name = "zhang"};
                var order = new Order {OrderId = 1 ,Customer = customer};
                var goods = new Goods { GoodsId = 1, Name = "apple", Price = 5 };
                order.Details = new List<OrderDetail>() {
                    new OrderDetail() {OrderDetailId =1,Num = 10 , Goods =goods},
                    new OrderDetail() {OrderDetailId =2,Num = 10 ,Goods = goods}
                };
                context.orders.Add(order);
                context.SaveChanges();
                newOrderId = order.OrderId;
            }

            //添加订单明细
            using (var context = new OrderContext())
            {
                var goods = new Goods { GoodsId = 1, Name = "book", Price = 9 };
                var orderDetail = new OrderDetail()
                {
                    OrderDetailId = 3,
                    Goods = goods,
                    Num = 10,
                };
                context.Entry(orderDetail).State = EntityState.Added;
                context.SaveChanges();
                newOrderDetailId = orderDetail.OrderDetailId;
            }

            //根据Id查找订单
            using (var context = new OrderContext())
            {
                var order = context.orders
                    .SingleOrDefault(b => b.OrderId == newOrderId);
                if (order != null) Console.WriteLine(order);
            }

            //修改Id为newOrderId的订单
            using (var context = new OrderContext())
            {
                var customer = new Customer { CustomerId = 2, Name = "li" };
                var order = new Order()
                {
                    OrderId = newOrderId,
                    Customer = customer,
                };
                order.Details = new List<OrderDetail>() {
                    new OrderDetail() {OrderDetailId =1,Num = 10},
                    new OrderDetail() {OrderDetailId =2,Num = 10}
                };
                context.Entry(order).State = EntityState.Modified;
                context.SaveChanges();
            }


            //删除Id为newOrderId的订单
            using (var context = new OrderContext())
            {
                var order = context.orders.FirstOrDefault(p => p.OrderId == newOrderId);
                if (order != null)
                {
                    context.orders.Remove(order);
                    context.SaveChanges();
                }
            }


        }
    }
}
