using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string UserName { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string UserSurname { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string UserMail { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(16)]
        public string UserPassword { get; set; }
        public bool UserRole { get; set; }
        public bool Status { get; set; }
    }
}
