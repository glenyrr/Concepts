using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Aspnet.Core.Data
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetFilteredAsync(Expression<Func<TEntity, bool>> where);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity) ;
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        Task<int> SaveChangesAsync();
    }
}
