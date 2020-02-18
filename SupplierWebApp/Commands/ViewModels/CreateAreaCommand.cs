using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierWebApp.Commands.ViewModels
{
    public class CreateAreaCommand : IRequest<bool>
    {
        public int AreaCod { get; set; }
        public string AreaName { get; set; }
    }
}
