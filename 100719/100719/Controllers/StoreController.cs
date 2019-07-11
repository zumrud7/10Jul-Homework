using _100719.DAL;
using _100719.Models;
using _100719.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _100719.Controllers
{
    public class StoreController : Controller
    {
        private readonly StoreContext _context;

        public StoreController()
        {
            _context = new StoreContext();
        }
        public ActionResult Index()
        {
            //List<Product> products = _context.Products.Include("Category").ToList();
            //List<Category> categories = _context.Categories.ToList();

            ViewStore model = new ViewStore
            {
                Products = _context.Products.Include("Category").ToList(),
                Categories = _context.Categories.ToList(),
                ProductSectionTitle = "Products",
                CategorySectionTitle = "Categories"
            };

            

            return View(model);
        }

      
    }
}