using ApiBestPractice.Core.Utilities.Results;
using ApiBestPractice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBestPractice.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetListCategory();
    }
}
