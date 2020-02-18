using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierWebApp.Queries.ReadRepository.Infrastructure
{
    public interface IBaseRepository<T> where T : class
    {

        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> GetWhereAsync(object obj);



    }
}
