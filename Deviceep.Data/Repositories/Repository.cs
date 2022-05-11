using Deviceep.Core.Repositories;
using Deviceep.Entity.AdditionalModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Deviceep.Data.Repositories
{

    // The real database connection and the one that creates the Queries
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        // Depency Injection
        public Repository(AppDbContext context)
        {
            _context = context; // bunula veri tabanına erişim
            _dbSet = context.Set<TEntity>(); // bunula tablolara erişim
        }


        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities) // Task async programlamada void'e karşılık gelir
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Remove(int id)
        {
            var entity = await _dbSet.FindAsync(id);
           _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.SingleOrDefaultAsync(predicate);
        }

        public TEntity Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public async Task<IPagedList<TEntity>> GetPagedList(RequestParams requestParams, List<string> includes = null)
        {
            IQueryable<TEntity> query = _dbSet;



            if (includes != null)
            {
                foreach (var includePropery in includes)
                {
                    query = query.Include(includePropery);
                }
            }




            return await query.AsNoTracking()
                .ToPagedListAsync(requestParams.PageNnumber, requestParams.PageSize);
        }
        public bool IsFieldValueUnique(Expression<Func<TEntity, bool>> predicate)
        {
            var alreadyExists = _dbSet.Any<TEntity>(predicate);

            return alreadyExists;
        }

        // Tabloda buna ait bu vsr mı id'si 3 olup o rowda 
        // courseid'si verdiğimiz yerle uyuşan var mı

        public bool IsEnrollExists(Expression<Func<TEntity, bool, bool>> predicate)
        {
            var alreadyExists = false;

            return alreadyExists;
        }
    }
}