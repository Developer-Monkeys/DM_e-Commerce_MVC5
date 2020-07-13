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
    public class CategoriesController : ApiController
    {
        // GET: api/Categories
        public List<Category> Get()
        {
            using (var dbContext = new Context())
            {
                return dbContext.Categories.Where(x => x.Status == true).ToList();
            }
        }

        // GET: api/Categories/5
        public Category Get(int id)
        {
            using (var dbContext = new Context())
            {
                var category = dbContext.Categories.Find(id);
                if (category != null && category.Status == true)
                {
                    return category;
                }
                else
                {
                    return null;
                }

            }
        }

        // POST: api/Categories
        public void Post(Category category)
        {
            using (var dbContext = new Context())
            {
                dbContext.Categories.Add(category);
                dbContext.SaveChanges();
            }
        }

        // PUT: api/Categories/5
        public void Put(int id,Category category)
        {
            using (var dbContext = new Context())
            {
                var update = dbContext.Categories.Find(id);

                if (update == null) return;

                update.CategoryName = category.CategoryName;
                
                dbContext.SaveChanges();
            }

        }

        // DELETE: api/Categories/5
        public void Delete(int id)
        {

            using (var dbContext = new Context())
            {
                var delete = dbContext.Categories.Find(id);

                if (delete == null) return;
                delete.Status = false;

                dbContext.SaveChanges();
            }
        }
    }
}
