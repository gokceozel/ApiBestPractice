using ApiBestPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBestPractice.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<T,Context> 
        where T:class,IEntity,new()
        where Context:DbContext ,new()
   
    {
    }
}
