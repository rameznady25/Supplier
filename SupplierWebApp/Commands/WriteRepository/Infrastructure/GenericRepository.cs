using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SupplierWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SupplierWebApp.Commands.WriteRepository.Infrastructure
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly SupplierContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(SupplierContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _dbSet = _dbContext.Set<T>();
        }


        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Added;
            _dbSet.Add(entity);

        }
        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity == null)
                return;

            Delete(entity);
        }
        public void Delete(T entity)
        {
            EntityEntry dbEntityEntry = _dbContext.Entry(entity);

            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                _dbSet.Attach(entity);
                _dbSet.Remove(entity);
            }
        }
        public void Update(T entity)
        {
            //_dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;

        }
        public void DetectUpdate(T entity)
        {
            _dbSet.Attach(entity);
            /* Now the entity framework will start tracking this object, 
                any update to the values will be tracked and persisted on commit*/
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public async Task<bool> SaveAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await _dbContext.SaveChangesAsync(cancellationToken);
            return true;
        }


    }
}
