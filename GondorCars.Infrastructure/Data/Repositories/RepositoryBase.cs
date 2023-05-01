using GondorCars.Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GondorCars.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly DataContext _dataContext;

        public RepositoryBase(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public void Add(TEntity entity)
        {
            try
            {
                _dataContext.Set<TEntity>().Add(entity);
                _dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dataContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _dataContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            try
            {
                _dataContext.Set<TEntity>().Remove(entity);
                _dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                _dataContext.Entry(entity).State = EntityState.Modified;
                _dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}