using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Services.Controllers
{
    public class LogInController : ApiController
    {

     
        // GET: api/LogIn
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/LogIn/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LogIn
        public string Post(User user)
        {
            
           using (var dbContext = new Context())
            {
                var result = dbContext.Users.FirstOrDefault(x => x.UserName == user.UserName  && x.UserPassword == user.UserPassword);
                if(result == null)
                {
                    return "Red";
                }
                else
                {
                    return "Ok";
                }
            }
        }

        // PUT: api/LogIn/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LogIn/5
        public void Delete(int id)
        {
        }
    }
}
