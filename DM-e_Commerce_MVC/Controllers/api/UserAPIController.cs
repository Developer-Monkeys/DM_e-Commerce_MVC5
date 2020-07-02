using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using  DM_e_Commerce_MVC.Models.Classes;

namespace DM_e_Commerce_MVC.Controllers.api
{
    public class UserApiController : ApiController
    {

        Context _cn = new Context();

        public List<User> Get()
        {
            _cn.Configuration.ProxyCreationEnabled = false;          //Serialize the relation table

            return _cn.Users.ToList();
        }

        public User Get(int id)
        {
            _cn.Configuration.ProxyCreationEnabled = false;
            var p = _cn.Users.Find(id);

            return p;
        }

        public IHttpActionResult PostUser(User u)                    //need ui 
        {
            _cn.Users.Add(u);
            _cn.SaveChanges();

            return Ok("Kullanıcı Başarıyla Kaydedildi");
        }
        public IHttpActionResult DeleteUser(int id)                  //need ui 
        {
            var data = _cn.Users.Find(id);
            if (data != null) data.UserRole = false;                   //role set "0" for now 
            _cn.SaveChanges();

            return Ok("Kullanıcı Başarıyla Silindi");
        }

        [HttpPut]
        public IHttpActionResult UpdateUser(User u)
        {
            var data = _cn.Users.Find(u.UserId);
            if (data != null)
            {
                data.UserName = u.UserName;
                data.UserMail = u.UserMail;
                data.UserRole = u.UserRole;
                data.UserSurname = u.UserSurname;
                data.UserPassword = u.UserPassword;
                _cn.SaveChanges();

                return Ok("Kullanıcı Başarıyla GÜncellendi");
            }
            else
            {
                return BadRequest("Hata");
            }
        }
    }
}
