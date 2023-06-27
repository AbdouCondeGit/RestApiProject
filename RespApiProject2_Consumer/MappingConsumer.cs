using AutoMapper;
using RespApiProject2_Consumer.Models.Dtos;
using RespApiProject2_Consumer.Models.Dtos.DTOs;

namespace RespApiProject2_Consumer
{
    public class MappingConsumer:Profile
    {
        public MappingConsumer()
        {
           

            CreateMap<VillaDTO, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaDTO, VillaUpdateDTO>().ReverseMap();

            CreateMap<VillaValueDTO, VillaValueCreateDTO>().ReverseMap();
            CreateMap<VillaValueDTO, VillaValueUpdateDTO>().ReverseMap();

            //CreateMap<Villa, VillaDTO>().ReverseMap();
            //CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            //CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
        }
    }

}
