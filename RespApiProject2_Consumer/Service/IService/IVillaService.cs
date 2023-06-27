using RespApiProject2_Consumer.Models.Dtos;
using RespApiProject2_Consumer.Models.Dtos.DTOs;

namespace RespApiProject2_Consumer.Service.IService
{
    public interface IVillaService
    {
        Task<T> GetVillaAsync<T>(int id);
        Task<T> GetAllVillasAsync<T>();
        Task<T> CreateVillAsynca<T>(VillaCreateDTO villaCreateDTO);
        Task<T> UpdateVillaAsync<T>(VillaUpdateDTO villaUpdateDTO);
        Task<T> DeleteVillaAsync<T>(int id);
    }
}
