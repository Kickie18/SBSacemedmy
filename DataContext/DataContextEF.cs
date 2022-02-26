using Microsoft.EntityFrameworkCore;
using SBSacemedmy.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBSacemedmy.DataContext
{
    public class DataContextEF : DbContext
    {
        public DataContextEF(DbContextOptions options) :base(options)
    {

        }
        //public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
