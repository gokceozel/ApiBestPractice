using ApiBestPractice.Core.DataAccess;
using ApiBestPractice.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBestPractice.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
