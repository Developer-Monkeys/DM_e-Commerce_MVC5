using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using DAL.Model;

namespace Services.Controllers
{
    public class UsersController : ApiController
    {
        // GET: api/Users
        public List<User> Get()
        {
            using (var dbContext = new Context())
            {
                return dbContext.Users.Where(x => x.Status == true).ToList();
            }
        }

        // GET: api/Users/5
        public User Get(int id)
        {
            using (var dbContext = new Context())
            {
                var user = dbContext.Users.Find(id);
                if (user != null && user.Status == true)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
        }

        // POST: api/Users
        public void Post(User user)
        {
            using (var dbContext = new Context())
            {
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
            }
        }

        // PUT: api/Users/5
        public void Put(int id, User user)
        {
            using (var dbContext = new Context())
            {
                var update = dbContext.Users.Find(id);

                if (update == null) return;

                update.UserMail = user.UserMail;
                update.UserName = user.UserName;
                update.UserSurname = user.UserSurname;
                update.UserPassword = user.UserPassword;
                update.UserRole = user.UserRole;

                dbContext.SaveChanges();
            }
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
            using (var dbContext = new Context())
            {
                var delete = dbContext.Users.Find(id);

                if (delete == null) return;
                delete.Status = false;

                dbContext.SaveChanges();
            }
        }
    }
}
