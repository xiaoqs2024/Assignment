using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Assignment7;
using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace Assignment7
{

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderContext : DbContext
    {
        public OrderContext() : base("BlogDataBase")
        {
            Database.SetInitializer(
              new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Assignment7.Order> orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }
        public DbSet<Goods> goods { get; set; }
        public DbSet<Customer> customers { get; set; }

    }
}
