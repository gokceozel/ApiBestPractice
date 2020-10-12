using ApiBestPractice.Core.DataAccess;
using ApiBestPractice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBestPractice.DataAccess.Abstract
{
    public interface IProductDal :IEntityRepository<Product>
    {
    }
}
