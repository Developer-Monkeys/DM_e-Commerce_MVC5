using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DM_e_Commerce_MVC.Models.Classes
{
    public class Product
    {
       
        [BsonId]
        [Key]
        public int ProductId { get; set; }
        [BsonElement("ProductName")]
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }
        [BsonElement("ProductStock")]
        public int ProductStock { get; set; }
        [BsonElement("ProductPrice")]

        public double ProductCost { get; set; }
        public double ProductPrice { get; set; }
        [BsonElement("ProductSeller")]
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string ProductSeller { get; set; }
        [BsonElement("ProductImage")]
        [Column(TypeName = "varchar")]
        [StringLength(250)]
        public string ProductImage { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int UserId { get; set; }
        public virtual User Seller { get; set; }
    }
}