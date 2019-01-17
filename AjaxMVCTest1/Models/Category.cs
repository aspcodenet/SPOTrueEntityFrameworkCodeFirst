using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxMVCTest1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual Category Category { get; set; }
    }

}