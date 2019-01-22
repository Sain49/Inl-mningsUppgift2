using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyECommerce.Models
{
    public class Product : IEnumerable
    {
        public int Id { get; set; }
        [Required]  
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Category_Id { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}