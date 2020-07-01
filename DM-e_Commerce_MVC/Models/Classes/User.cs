using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DM_e_Commerce_MVC.Models.Classes
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string User_Surname { get; set; }
        public string User_Mail { get; set; }
        public string User_Password { get; set; }
        public string User_Role { get; set; }

    }
}