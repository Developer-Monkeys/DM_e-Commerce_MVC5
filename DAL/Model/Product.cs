using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Product
    {

        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public double ProductCost { get; set; }
        public double ProductPrice { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string ProductSeller { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(250)]
        public string ProductImage { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
