using Deviceep.Entity.AdditionalModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Deviceep.Core.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync(); // tüm nesneler 

        Task<IPagedList<TEntity>> GetPagedList(
            RequestParams requestParams,
            List<string> includes = null

            );
        bool IsFieldValueUnique(Expression<Func<TEntity, bool>> predicate);
        bool IsEnrollExists(Expression<Func<TEntity, bool, bool>> predicate);
        Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate); // herhangi bir parametreye göre

        Task<TEntity> AddAsync(TEntity entity);

        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities); // toplu kayıt

        Task Remove(int id);

        void RemoveRange(IEnumerable<TEntity> entities);

        TEntity Update(TEntity entity);
    }
}
