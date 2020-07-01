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
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public int Product_Stock { get; set; }
        public double Product_Price { get; set; }
        public string Product_Seller { get; set; }
        public string Product_Image { get; set; }
        public virtual Category Category { get; set; }
    }
}