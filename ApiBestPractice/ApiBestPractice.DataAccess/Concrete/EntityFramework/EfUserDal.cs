using ApiBestPractice.Core.DataAccess.EntityFramework;
using ApiBestPractice.Core.Entities.Concrete;
using ApiBestPractice.DataAccess.Abstract;
using ApiBestPractice.DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBestPractice.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            throw new NotImplementedException();
        }
    }
}
