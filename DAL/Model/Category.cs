using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
        public bool Status { get; set; }
    }
}
