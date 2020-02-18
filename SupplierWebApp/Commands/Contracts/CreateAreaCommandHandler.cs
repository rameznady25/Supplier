using MediatR;
using SupplierWebApp.Commands.ViewModels;
using SupplierWebApp.Commands.WriteRepository;
using SupplierWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SupplierWebApp.Commands.Contracts
{
    public class CreateAreaCommandHandler : IRequestHandler<CreateAreaCommand, bool>
    {
        private readonly IAreaRepository _writeRepository;
        private readonly IServiceProvider _serviceProvider;
        private readonly IMediator _mediator;


        ////////////////////////////////////////////////////////////////////////////////////////////////
        //private const string title = "CQRS Task";


        public CreateAreaCommandHandler(IMediator mediator, IAreaRepository writeRepository)
        {
            _mediator = mediator;
            _writeRepository = writeRepository;
        }



        public async Task<bool> Handle(CreateAreaCommand request, CancellationToken cancellationToken)
        {


            var area = new Area();
            area.AreaCod = request.AreaCod;
            area.AreaName = request.AreaName;

            _writeRepository.Add(area);
            //_writeRepository.Save();

            return await _writeRepository.SaveAsync(cancellationToken);

        }
    }
}
