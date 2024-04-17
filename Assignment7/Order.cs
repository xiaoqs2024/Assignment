using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment7
{
    //订单
    public class Order {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public Customer Customer { get; set; }
        public List<OrderDetail> Details { get; set; }
    }
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public Goods Goods { get; set; }
        public int Num { get; set; }

        public int OrderId { get; set; }//外键
        public Order Order { get; set; }
    }
    public class Goods
    {
        [Key]
        public int GoodsId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }

        public int OrderDetailId { get; set; }//外键
        public OrderDetail OrderDetail {  get; set; }

    }
    public class Customer 
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        public int OrderId { get; set; }//外键
        public Order Order { get; set; }
    }

}