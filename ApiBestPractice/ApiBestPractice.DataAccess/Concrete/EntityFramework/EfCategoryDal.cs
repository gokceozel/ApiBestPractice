using ApiBestPractice.Core.DataAccess;
using ApiBestPractice.Core.DataAccess.EntityFramework;
using ApiBestPractice.DataAccess.Concrete.EntityFramework.Contexts;
using ApiBestPractice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ApiBestPractice.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal :EfEntityRepositoryBase<Category,NorthwindContext>
    {
    }
}
