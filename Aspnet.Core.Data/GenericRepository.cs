using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Aspnet.Core.Data
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;            
        }
       
        public void Dispose()
        {
            _context.Dispose();
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

       public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {            
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetFilteredAsync(Expression<Func<TEntity, bool>> predicate) 
        {
            return await _context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> predicate) 
        {
            return await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        public void Remove(TEntity entity) 
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }

        public async Task<int> SaveChangesAsync()
        {
            var result = _context.SaveChangesAsync();
            return await result;
        }
    }
}
