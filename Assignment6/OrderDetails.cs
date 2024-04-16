using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    //订单明细
    public class OrderDetails
    {
        public int Index { get; set; }
        public Goods Goods { get; set; }
        public int Num { get; set; }

        public OrderDetails() { }
        public OrderDetails(int Index, Goods goods, int num)
        {
            this.Index = Index;
            this.Goods = goods;
            this.Num = num;
        }
    }
}
