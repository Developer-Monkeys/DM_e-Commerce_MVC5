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
    public class ProductsController : ApiController
    {
        // GET: api/Products
        public List<Product> Get()
        {
            using ( var dbContext= new Context())
            {
                return dbContext.Products.Where(x=>x.Status==true).ToList();
            }
        }

        // GET: api/Products/5
        public Product Get(int id)
        {
            using (var dbContext = new Context())
            {
                var product = dbContext.Products.Find(id);
                if (product != null && product.Status==true)
                {
                    return dbContext.Products.Find(id);
                }
                else
                {
                    return null;
                }
              
            }
        }

        // POST: api/Products
        public void Post(Product product)
        {
            using (var dbContext = new Context())
            {
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
            }
        }

        // PUT: api/Products/5
        public void Put(int id, Product product)
        {
            using (var dbContext = new Context())
            {
                var update = dbContext.Products.Find(id);

                if (update == null) return;

                update.CategoryId = product.CategoryId;
                update.ProductCost = product.ProductCost;
                update.ProductImage = product.ProductImage;
                update.ProductName = product.ProductName;
                update.ProductSeller = product.ProductSeller;
                update.ProductStock = product.ProductStock;
                update.ProductPrice = product.ProductPrice;
                update.UserId = product.UserId;

                dbContext.SaveChanges();
            }
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
            using (var dbContext = new Context())
            {
                var delete = dbContext.Products.Find(id);

                if (delete == null) return;
                delete.Status = false;

                dbContext.SaveChanges();
            }
        }
    }
}
