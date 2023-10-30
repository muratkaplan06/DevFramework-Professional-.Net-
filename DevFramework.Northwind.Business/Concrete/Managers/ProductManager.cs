using System.Collections.Generic;
using DevFramework.Core.DataAccess;
using DevFramework.Norhwind.Entities.Concrete;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.DataAccess.Abstract;



namespace DevFramework.Northwind.Business.Concrete.Managers
{
    public class ProductManager:IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IQueryableRepository<Product> _quaRepository;

        public ProductManager(IProductDal productDal,IQueryableRepository<Product> quaRepository)
        {
            _productDal = productDal;
            _quaRepository = quaRepository;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        public Product Add(Product product)
        {
           
            return _productDal.Add(product);
        }

        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
