using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using _100719.Models;

namespace _100719.DAL
{
    public class StoreContext: DbContext
    {
        public StoreContext(): base("StoreContext")
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

    }
}