using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyECommerce.Models;

namespace MyECommerce.ViewModels
{
    public class CategoryFormViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}