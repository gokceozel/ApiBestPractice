using ApiBestPractice.Business.Abstract;
using ApiBestPractice.Business.Constants;
using ApiBestPractice.Core.Utilities.Results;
using ApiBestPractice.DataAccess.Abstract;
using ApiBestPractice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult DeleteProduct(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(x => x.ProductId == id));
        }

        public IDataResult<List<Product>> GetListByCategory(int catId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(x=>x.CategoryId==catId).ToList());
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
