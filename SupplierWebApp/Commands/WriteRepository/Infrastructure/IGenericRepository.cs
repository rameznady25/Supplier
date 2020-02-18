using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SupplierWebApp.Commands.WriteRepository.Infrastructure
{
    public interface IGenericRepository<T> where T : class
    {

        void Add(T entity);
        void Update(T entity);
        void DetectUpdate(T entity);
        void Delete(T entity);
        void Delete(int id);
        void Save();
        Task<bool> SaveAsync(CancellationToken cancellationToken = default(CancellationToken));

    }
}