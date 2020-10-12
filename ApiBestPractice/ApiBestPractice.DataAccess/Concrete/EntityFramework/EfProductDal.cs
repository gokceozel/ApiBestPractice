using ApiBestPractice.Core.DataAccess.EntityFramework;
using ApiBestPractice.DataAccess.Abstract;
using ApiBestPractice.DataAccess.Concrete.EntityFramework.Contexts;
using ApiBestPractice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBestPractice.DataAccess.Concrete.EntityFramework
{
   public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext> ,IProductDal
    {
    }
}
