using AutoMapper;
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
    public class AreaUpdateCommandHandler : IRequestHandler<AreaUpdateCommand, bool>
    {
        private readonly IAreaRepository _writeRepository;
        private readonly IServiceProvider _serviceProvider;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;


        ////////////////////////////////////////////////////////////////////////////////////////////////
        private const string title = "CQRS Task";

        public AreaUpdateCommandHandler(IMediator mediator, IAreaRepository writeRepository, IMapper mapper)
        {
            _mediator = mediator;
            _writeRepository = writeRepository;
            _mapper = mapper;
        }



        ////////////////////////////////////////////////////////////////////////////////////////////////



        public async Task<bool> Handle(AreaUpdateCommand request, CancellationToken cancellationToken)
        {



            var area = new Area();
            area.AreaName = request.AreaName;
            area.AreaCod = request.AreaCod;

            _writeRepository.Update(area);
            //_writeRepository.Save();

            return await _writeRepository.SaveAsync(cancellationToken);

        }
    }
}

