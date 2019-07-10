namespace _100719.Migrations
{
    using _100719.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_100719.DAL.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(_100719.DAL.StoreContext context)
        {

            //Category ctg = new Category
            //{
            //    Name = "Clothes"
            //};

            //Category ctg1 = new Category
            //{
            //    Name = "Food"
            //};


            //context.Categories.Add(ctg);
            //context.Categories.Add(ctg1);

            //context.SaveChanges();

            //Product prd = new Product
            //{
            //    Name = "Shoes",
            //    Price = 20,
            //    CategoryId = 1
            //};

            //Product prd1 = new Product
            //{
            //    Name = "Pasta",
            //    Price = 3,
            //    CategoryId = 1
            //};
            //Product prd2 = new Product
            //{
            //    Name = "Pants",
            //    Price = 32,
            //    CategoryId = 1
            //};

            //Product prd3 = new Product
            //{
            //    Name = "Broccoli",
            //    Price = 5,
            //    CategoryId = 2
            //};

            //context.Products.Add(prd);
            //context.Products.Add(prd2);
            //context.Products.Add(prd3);

            //context.SaveChanges();
        }
    }
}
