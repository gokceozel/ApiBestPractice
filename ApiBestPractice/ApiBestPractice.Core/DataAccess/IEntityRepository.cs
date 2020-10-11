using ApiBestPractice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ApiBestPractice.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T,bool>> filter);
        IList<T> GetList(Expression<Func<T,bool>> filter=null);
       // IQueryable<T> SearchText(IQueryable<T> query, string text);

    }
}
