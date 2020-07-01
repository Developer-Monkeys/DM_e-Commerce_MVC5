using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DM_e_Commerce_MVC.Models.Classes
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public double ProductPrice { get; set; }
        public string ProductSeller { get; set; }
        public string ProductImage { get; set; }
        public virtual Category Category { get; set; }
    }
}