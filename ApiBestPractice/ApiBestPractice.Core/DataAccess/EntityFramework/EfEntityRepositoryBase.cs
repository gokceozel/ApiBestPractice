using ApiBestPractice.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ApiBestPractice.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<T, TContext> : IEntityRepository<T>
        where T : class, IEntity, new()
        where TContext : DbContext, new()

    {
        public void Add(T entity)
        {
            using (var context = new TContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.Add(added);
                context.SaveChanges();
            }
        }

        public void AddList(List<T> list)
        {
            using(var context=new TContext())
            {
                var added = context.Entry(list);
                added.State = EntityState.Added;
                context.AddRangeAsync(added);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using(var context=new TContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (var context=new TContext())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public IList<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<T>().ToList()
                                     : context.Set<T>().Where(filter).ToList();
            }
        }

        #region Eklenecek
        //public IQueryable<T> SearchText(IQueryable<T> query, string text)
        //{//BUSİNESS İÇİNDE YAZ

        //    throw new NotImplementedException();
        //    //return query.Where(d => EF.Functions.Like(d., $"%{text}%"));
        //}
        #endregion
        public void Update(T entity)
        {
            using (var context=new TContext())
            {
                var updated = context.Entry(entity);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
