using Assignment5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment5
{
    [TestClass]
    public class OrderServiceTest
    {
        List<Order> orders = new List<Order>() {
            new Order("computer",10, "001","huawei","Jack",3000)
        };
        OrderService ods = new OrderService();
        [TestMethod]
        public void AddOrderTest()
        {
            List<Order> result = new List<Order>() {
            new Order("computer",10, "001","huawei","Jack",3000),
            new Order("computer", 6, "002", "oppo", "Olivia", 8000)
            };
            //Ìí¼Ó¶©µ¥
            ods.AddOrder("computer", 6, "002", "oppo", "Olivia", 8000, orders);
            Assert.AreEqual(result,orders);
        }
        [TestMethod]
        public void DeleteOrderTest()
        {
            List<Order> result = new List<Order>() {
            new Order("computer",10, "001","huawei","Jack",3000)
            };
            //É¾³ý¶©µ¥
            Order order = new Order("computer", 6, "002", "oppo", "Olivia", 8000);
            ods.DeleteOrder(order, orders);
            Assert.AreEqual(result, orders);
        }
        [TestMethod]
        public void ChangeOrderTest()
        {
            List<Order> result = new List<Order>() {
            new Order("computer", 10, "001", "huawei", "El", 3000)
            };
            //ÐÞ¸Ä¶©µ¥
            Order order1 = new Order("computer", 10, "001", "huawei", "Jack", 3000);
            Order order2 = new Order("computer", 10, "001", "huawei", "El", 3000);
            ods.ChangeOrder(order1, order2, orders);
            Assert.AreEqual(result, orders);
        }
    }
}