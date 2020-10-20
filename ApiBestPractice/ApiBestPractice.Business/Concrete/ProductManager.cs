using ApiBestPractice.Business.Abstract;
using ApiBestPractice.Core.Utilities.Results;
using ApiBestPractice.DataAccess.Abstract;
using ApiBestPractice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBestPractice.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetListByCategory(int catId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetListProduct()
        {
            throw new NotImplementedException();
        }

        public IResult UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
