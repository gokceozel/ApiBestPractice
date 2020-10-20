using ApiBestPractice.Core.Utilities.Results;
using ApiBestPractice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBestPractice.Business.Abstract
{
    public  interface IProductService
    {
        IDataResult<List<Product>> GetListProduct();
        IDataResult<List<Product>> GetListByCategory(int catId);
        IDataResult<Product> GetById(int id);
        IResult AddProduct(Product product);
        IResult UpdateProduct(Product product);
        IResult DeleteProduct(Product product);
    }
}
