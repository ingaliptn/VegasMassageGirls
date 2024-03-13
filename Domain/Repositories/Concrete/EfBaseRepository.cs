using Domain.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Repositories.Concrete
{
    public class EfBaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly EfDbContext Context;
        private readonly DbSet<TEntity> _set;
        private bool _disposed;

        protected EfBaseRepository(EfDbContext db)
        {
            Context = db;
            _set = Context.Set<TEntity>();
        }

        public virtual void Create(TEntity entity)
        {
            _set.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _set.Update(entity);
        }

        public virtual void Remove(TEntity entity)
        {
            _set.Remove(entity);
        }

        public virtual async Task RemoveFromId(int id)
        {
            var i = await GetAsync(id);
            _set.Remove(i);
            await SaveChangesAsync();
        }

        public virtual async Task RemoveFromIdS(int id)
        {
            var i = await GetAsync(id);
            _set.Remove(i);
        }

        public virtual async Task<TEntity> GetAsync(int id)
        {
            return await _set.FindAsync(id);
        }

        public virtual TEntity Get(int id) => _set.Find(id);

        public virtual IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return _set.AsEnumerable().Where(predicate);
        }

        public virtual IEnumerable<TEntity> GetAsNoTracking(Func<TEntity, bool> predicate)
        {
            return _set.AsNoTracking().AsEnumerable().Where(predicate);
        }

        public virtual void CreateRange(IEnumerable<TEntity> records) => _set.AddRange(records);

        public virtual IQueryable<TEntity> SearchQueryable(string filter)
        {
            var type = typeof(TEntity);
            var properties = type.GetProperties()
                .Where(prop => prop.IsDefined(typeof(SearchableAttribute), false));
            var list = properties.Select(p => GetExpression<TEntity>(p.Name, filter))
                .Where(lambda => lambda != null).ToList();
            if (list.Count == 0) return null;
            if (list.Count == 1) return _set.Where(list[0]);
            var filterExpr = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                filterExpr = filterExpr.Or(list[i]);
            }
            return _set.Where(filterExpr);
        }

       

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (_disposed) return;
            Context?.Dispose();
            _disposed = true;
        }
        private Expression<Func<T, bool>> GetExpression<T>(string propertyName, string propertyValue)
        {
            var parameterExp = Expression.Parameter(typeof(T), "type");
            var propertyExp = Expression.Property(parameterExp, propertyName);
            var method = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            var someValue = Expression.Constant(propertyValue, typeof(string));
            var containsMethodExp = Expression.Call(propertyExp, method ?? throw new InvalidOperationException(), someValue);
            return Expression.Lambda<Func<T, bool>>(containsMethodExp, parameterExp);
        }
    }
}
