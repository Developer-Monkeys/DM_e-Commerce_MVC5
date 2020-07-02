using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DM_e_Commerce_MVC.Models.Classes
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
        public bool Status  { get; set; }
    }
}