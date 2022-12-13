using CoreLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Data.Concrete
{
    public class EfEntityRepositoryBase<T> : IEntityRepository<T> where T : class
    {

        protected readonly DbContext _dbContext; 

        // Constructor
        public EfEntityRepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Asenkron Add Routine
        public async Task AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        // Asenkron Any Routine & Boolean
        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().AnyAsync(predicate);
        }

        // Asenkron Counting Routine & Integer
        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            return await (predicate == null ? _dbContext.Set<T>().CountAsync() : _dbContext.Set<T>().CountAsync(predicate));
        }

        // Asenkron Delete Routine
        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => { _dbContext.Set<T>().Remove(entity); });
            await _dbContext.SaveChangesAsync();
        }

        // Asenkron Get All Routine
        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbContext.Set<T>();

            if(predicate != null)
            {
                query = query.Where(predicate);
            }

            if(includeProperties.Any())
            {
                foreach(var inculudeProperty in includeProperties)
                {
                    query = query.Include(inculudeProperty);
                }
            }
            return await query.ToListAsync();
        }

        // Asenkron Get Routine & Customer Full Name
        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbContext.Set<T>(); 

            if (predicate != null)
            {
                query = query.Where(predicate); 
            }

            if (includeProperties.Any())
            {
                foreach (var inculudeProperty in includeProperties)
                {
                    query = query.Include(inculudeProperty);
                }
            }
            return await query.SingleOrDefaultAsync(); 
        }

        // Asenkron Get Routine & By Id
        public async Task<T> GetById(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbContext.Set<T>(); 

            if (predicate != null)
            {
                query = query.Where(predicate); 
            }

            if (includeProperties.Any())
            {
                foreach (var inculudeProperty in includeProperties)
                {
                    query = query.Include(inculudeProperty); 
                }
            }
            return await query.SingleOrDefaultAsync();
        }

        // Asenkron Update Routine
        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() => { _dbContext.Set<T>().Update(entity); });
            await _dbContext.SaveChangesAsync();
        }
    }
}
