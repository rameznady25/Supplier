using SupplierWebApp.Commands.WriteRepository.Infrastructure;
using SupplierWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierWebApp.Commands.WriteRepository
{
    public class AreaRepository : GenericRepository<Area>, IAreaRepository
    {
        public AreaRepository(SupplierContext dbContext) : base(dbContext)
        {

        }
    }
}
