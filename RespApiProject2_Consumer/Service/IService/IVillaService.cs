using RespApiProject2_Consumer.Models.Dtos;
using RespApiProject2_Consumer.Models.Dtos.DTOs;

namespace RespApiProject2_Consumer.Service.IService
{
    public interface IVillaService
    {
        Task<T> GetVillaAsync<T>(int id, string token);
        Task<T> GetAllVillasAsync<T>(string token);
        Task<T> CreateVillAsynca<T>(VillaCreateDTO villaCreateDTO, string token);
        Task<T> UpdateVillaAsync<T>(VillaUpdateDTO villaUpdateDTO, string token);
        Task<T> DeleteVillaAsync<T>(int id, string token);
    }
}
