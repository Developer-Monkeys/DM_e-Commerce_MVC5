using DAL.Model;

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
      
        public Context()
            : base("name=Context")
        {
            Database.SetInitializer(new Config());
            Configuration.ProxyCreationEnabled = false;
        }

        public  virtual  DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public  virtual  DbSet<Category>  Categories { get; set; }

    }

    public class Config : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            context.Categories.Add(new Category()
            {
                CategoryName = "TestKategorisi",
                Status = true

            });
            context.Categories.Add(new Category()
            {
                CategoryName = "TestKategorisi2",
                Status = true

            });
            context.Users.Add(new User()
            {
                UserName = "TestKullanýcýadý",
                UserSurname = "TestSoyad",
                UserMail = "test@test.com",
                UserRole = true,
                UserPassword = "testsifre",
                Status = true

            });
            context.Users.Add(new User()
            {
                UserName = "TestKullanýcýadý2",
                UserSurname = "TestSoyad2",
                UserMail = "test2@test.com",
                UserRole = true,
                UserPassword = "testsifre",
                Status = true

            });
        }
    }
}