using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DM_e_Commerce_MVC.Models.Classes;

namespace DM_e_Commerce_MVC.Controllers.api
{
    public class CategoryApiController : ApiController
    {

        Context _cn = new Context();

        public List<Category> Get()
        {
            _cn.Configuration.ProxyCreationEnabled = false;          //Serialize the relation table

            return _cn.Categories.ToList();
        }

        public Category Get(int id)
        {
            _cn.Configuration.ProxyCreationEnabled = false;
            var c = _cn.Categories.Find(id);

            return c;
        }

        public IHttpActionResult PostCategory(Category c)            //need ui 
        {
            _cn.Categories.Add(c);
            _cn.SaveChanges();

            return Ok("Kategori Başarıyla Kaydedildi");
        }
        public IHttpActionResult DeleteCategory(int id)              //need ui 
        {
            var data = _cn.Categories.Find(id);
            if (data != null) data.CategoryName = "0";               //name set "0" for now 
            _cn.SaveChanges();

            return Ok("Kategori Başarıyla Silindi");
        }

        [HttpPut]
        public IHttpActionResult UpdateCategory(Category u)
        {
            var data = _cn.Categories.Find(u.CategoryId);
            if (data != null)
            {
                data.CategoryName = u.CategoryName;
                _cn.SaveChanges();

                return Ok("Kategori Başarıyla GÜncellendi");
            }
            else
            {
                return BadRequest("Hata");
            }
        }
    }
}