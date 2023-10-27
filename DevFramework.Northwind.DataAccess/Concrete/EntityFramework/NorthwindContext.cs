using System.Data.Entity;
using DevFramework.Norhwind.Entities.Concrete;
using DevFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {

        public NorthwindContext()
        {
            //database oluşturulurken veritabanı oluşturulurken tabloları oluşturması engellendi.
            Database.SetInitializer<NorthwindContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
