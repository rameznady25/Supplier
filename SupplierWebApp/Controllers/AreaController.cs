﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupplierWebApp.Commands.ViewModels;
using SupplierWebApp.Models;
using SupplierWebApp.Queries.Contracts;
using SupplierWebApp.Queries.ViewModels;

namespace SupplierWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        //private readonly IQueryDispatcher queryDispatcher;
        private readonly IMediator _mediator;
        private readonly IAreaQueries _areaQueries;
        private readonly IMapper _mapper;


        public AreaController(IMediator mediator, IAreaQueries areaQueries, IMapper mapper)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _areaQueries = areaQueries ?? throw new ArgumentNullException(nameof(areaQueries));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }




        [HttpGet]
        public async Task<ActionResult<IEnumerable<AreaViewModel>>> GetAreas()
        {
            await _areaQueries.GetWhereAsync(new { AreaCod = 2});

            IEnumerable<Area> pvm = await _areaQueries.GetAllAsync();
            IEnumerable<AreaViewModel> areas = _mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(pvm);
            return Ok(areas);
        }




        [HttpGet("{id}")]
        public async Task<ActionResult<AreaViewModel>> GetArea(int id)
        {
            var a = await _areaQueries.GetByIdAsync(Convert.ToInt32(id));
            AreaViewModel area = _mapper.Map<Area, AreaViewModel>(a);

            if (area == null)
            {
                return NotFound();
            }
            return area;
        }






        [HttpPost]
        public async Task<ActionResult<Area>> PostAreas(Area value)
        {
            var c = new CreateAreaCommand();
            c.AreaName = value.AreaName;
            c.AreaCod = value.AreaCod;

            var result = false;
            result = await _mediator.Send(c);
            if (!result)
            {
                return value;
            }
            return null;

        }




        [HttpPut("{id}")]
        public async Task<ActionResult<Area>> PutPost(int id, Area post)
        {
            if (id != post.AreaCod)
            {
                return BadRequest();
            }


            var c = new AreaUpdateCommand();
            c.AreaName = post.AreaName;
            c.AreaCod = post.AreaCod;


            var result = false;
            result = await _mediator.Send(c);
            if (!result)
            {
                return post;
            }
            return NoContent();

        }





        [HttpDelete]
        public async Task<ActionResult> Delete(DeleteAreaCommand Id)
        {
            return Ok(await _mediator.Send(Id));
        }









    }
}
