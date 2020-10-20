using ApiBestPractice.Business.Abstract;
using ApiBestPractice.Core.Utilities.Results;
using ApiBestPractice.DataAccess.Abstract;
using ApiBestPractice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBestPractice.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IDataResult<List<Category>> GetListCategory()
        {
            throw new NotImplementedException();
        }
    }
}
