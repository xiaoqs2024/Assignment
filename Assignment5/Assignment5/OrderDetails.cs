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
        public string typeName { get; set; }//种类
        public int heat { get; set; }//销售热度1~10

        public OrderDetails() { }
        public OrderDetails(string typeName, int heat)
        {
            this.typeName = typeName;
            this.heat = heat;
        }
    }
}
