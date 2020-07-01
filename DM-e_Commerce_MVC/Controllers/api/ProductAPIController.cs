using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DM_e_Commerce_MVC.Models.Classes;

namespace DM_e_Commerce_MVC.Controllers.api
{
    public class ProductApiController : ApiController
    {
        Context _cn= new Context();

        public List<Product> Get()
        {
            _cn.Configuration.ProxyCreationEnabled = false;          //Serialize the relation table

            return _cn.Products.ToList();
        }

        public Product Get(int id)
        {
            _cn.Configuration.ProxyCreationEnabled = false;
            var p = _cn.Products.Find(id);

            return p;
        }

        public IHttpActionResult PostProduct(Product p)              //need ui 
        {
            _cn.Products.Add(p);
            _cn.SaveChanges();

            return Ok("Ürün Başarıyla Kaydedildi") ;
        }
        public IHttpActionResult DeleteProduct(int id)               //need ui 
        {
            var data=_cn.Products.Find(id);
            if (data != null) data.ProductStock = 0;                 //stock set "0" for now 
            _cn.SaveChanges();

            return Ok("Ürün Başarıyla Silindi");
        }

        [HttpPut]
        public IHttpActionResult UpdateProduct(Product p)             
        {
            var data = _cn.Products.Find(p.ProductId);
            if (data != null)
            {
                data.ProductName = p.ProductName;
                data.ProductStock = p.ProductStock;
                data.ProductImage = p.ProductImage;
                data.ProductPrice = p.ProductPrice;
                data.ProductSeller = p.ProductSeller;
                //_data.Product_Category=p.Product_Category              
                _cn.SaveChanges();
                return Ok("Ürün Başarıyla GÜncellendi");
            }
            else
            {
                return BadRequest("Hata");
            }

           
        }
    }
}
