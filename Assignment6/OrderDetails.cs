using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    //订单明细
    public class OrderDetails
    {
        public Goods goods;
        public int num;
        public int money;

        public OrderDetails() { }
        public OrderDetails(Goods goods, int num)
        {
            this.goods = goods;
            this.num = num;
            money = goods.Price * num;
        }
    }
}
