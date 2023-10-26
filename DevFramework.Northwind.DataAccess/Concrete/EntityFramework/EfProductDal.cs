using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Norhwind.Entities.Concrete;
using DevFramework.Northwind.DataAccess.Abstract;
using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;

namespace DevFramework.Northwind.DataAccess.Concrete
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
        
    }
}
