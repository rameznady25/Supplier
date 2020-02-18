using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SupplierWebApp.Commands.ViewModels
{
    [DataContract]
    public class DeleteAreaCommand : IRequest<bool>
    {
        [DataMember]
        public int AreaCod { get; private set; }


        public DeleteAreaCommand()
        {

        }

        public DeleteAreaCommand(int id) : this()
        {
            AreaCod = id;
        }
    }

}
