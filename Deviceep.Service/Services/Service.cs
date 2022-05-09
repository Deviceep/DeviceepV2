using Deviceep.Core.Repositories;
using Deviceep.Core.Services;
using Deviceep.Core.UnitOfWorks;
using Deviceep.Entity.AdditionalModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace Deviceep.Service.Services
{
    // Taking the database communication from Repository
    // Taking the Connections from the unit of work
    // Used in controllers for descrete connection between database and client
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        // Definition of variables for Dependency Injection
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<TEntity> _repository;

        // Constructor for the class
        // Initiating the dependency injection
        public Service(IUnitOfWork unitOfWork, IRepository<TEntity> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }


        // Basic Dataabase Addition
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        // Multiple Data entry at once
        public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _repository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }

        // Taking all the Information in a database table
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        // Specific Get function defined by id
        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        // Getting a specified number of entries
        public async Task<IPagedList<TEntity>> GetPagedList(RequestParams requestParams, List<string> includes = null)
        {
            return await _repository.GetPagedList(requestParams);
        }

        // Deleting an entry
        public async Task Remove(int id)
        {
            await _repository.Remove(id);
            _unitOfWork.Commit();
        }

        // Deleting Multiple Entries
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _repository.RemoveRange(entities);
            _unitOfWork.Commit();
        }

        // Finding an entry
        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _repository.SingleOrDefaultAsync(predicate);
        }

        
        // Changing the information in an entry
        public TEntity Update(TEntity entity)
        {
            TEntity updatedEntity = _repository.Update(entity);
            _unitOfWork.Commit();
            return updatedEntity;
        }


        // Specific Query
        public async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return await _repository.Where(predicate);
        }

        

        
    }
}
