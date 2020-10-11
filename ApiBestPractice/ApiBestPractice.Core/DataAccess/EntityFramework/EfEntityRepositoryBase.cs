using ApiBestPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ApiBestPractice.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<T, Context> : IEntityRepository<T>
        where T : class, IEntity, new()
        where Context : DbContext, new()

    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> SearchText(IQueryable<T> query, string text)
        {

            throw new NotImplementedException();
            //return query.Where(d => EF.Functions.Like(d., $"%{text}%"));
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
