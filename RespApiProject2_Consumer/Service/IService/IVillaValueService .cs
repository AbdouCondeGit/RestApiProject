using RespApiProject2_Consumer.Models.Dtos;
using RespApiProject2_Consumer.Models.Dtos.DTOs;

namespace RespApiProject2_Consumer.Service.IService
{
    public interface IVillaValueService
    {
        Task<T> GetVillaValueAsync<T>(int id);
        Task<T> GetAllVillaValuesAsync<T>();
        Task<T> CreateVillaValueAsynca<T>(VillaValueCreateDTO villaCreateDTO);
        Task<T> UpdateVillaValueAsync<T>(VillaValueUpdateDTO villaUpdateDTO);
        Task<T> DeleteVillaValueAsync<T>(int id);
    }
}
