using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyECommerce.Models;

namespace MyECommerce.ViewModels
{
    public class ProductFormViewModel
    {
        [Display(Name = "Product Category")]
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
        public Product Product { get; set; }
    }
}