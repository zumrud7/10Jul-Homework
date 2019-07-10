using _100719.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _100719.ViewModels
{
    public class ViewStore
    {
        public string  ProductSectionTitle { get; set; }

        public string CategorySectionTitle { get; set; }

        public List<Product> Products { get; set; }

        public List<Category> Categories { get; set; }
    }
}