using MediatR;
using SupplierWebApp.Commands.ViewModels;
using SupplierWebApp.Commands.WriteRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace SupplierWebApp.Commands.Contracts
{


    public class DeleteAreaCommandHandler : IRequestHandler<DeleteAreaCommand, bool>
    {


        private readonly IAreaRepository _writeRepository;
        private readonly IMediator _mediator;

        // Using DI to inject infrastructure persistence Repositories
        public DeleteAreaCommandHandler(IMediator mediator, IAreaRepository writeRepository)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _writeRepository = writeRepository ?? throw new ArgumentNullException(nameof(writeRepository));
        }

        public async Task<bool> Handle(DeleteAreaCommand request, CancellationToken cancellationToken)
        {

            _writeRepository.Delete(request.AreaCod);

            //return await writeRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
            return await _writeRepository.SaveAsync(cancellationToken);

        }



    }
}
