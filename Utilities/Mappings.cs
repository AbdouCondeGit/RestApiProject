using AutoMapper;
using Models;
using Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Mappings:Profile
    {
        public Mappings()
        {
            CreateMap<Villa, VillaDTO>().ReverseMap();
            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();

            CreateMap<VillaValue, VillaValueDTO>().ReverseMap();
            CreateMap<VillaValue, VillaValueCreateDTO>().ReverseMap();
            CreateMap<VillaValue, VillaValueUpdateDTO>().ReverseMap();

        }
        

        
    }
}
