using AutoMapper;
using SupplierWebApp.Models;
using SupplierWebApp.Queries.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierWebApp.MapppingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Area, AreaViewModel>();
        }
    }
}
