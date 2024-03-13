using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {

        void Create(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);
        Task RemoveFromId(int id);
        Task RemoveFromIdS(int id);
        Task<TEntity> GetAsync(int id);
        TEntity Get(int id);
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        IEnumerable<TEntity> GetAsNoTracking(Func<TEntity, bool> predicate);
        void CreateRange(IEnumerable<TEntity> records);
        IQueryable<TEntity> SearchQueryable(string filter);

        void SaveChanges();

        Task<int> SaveChangesAsync();
    }
}
