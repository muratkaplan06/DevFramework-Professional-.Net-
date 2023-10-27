using System.Collections.Generic;
using DevFramework.Core.DataAccess;
using DevFramework.Norhwind.Entities.ComplexType;
using DevFramework.Norhwind.Entities.Concrete;

namespace DevFramework.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}
