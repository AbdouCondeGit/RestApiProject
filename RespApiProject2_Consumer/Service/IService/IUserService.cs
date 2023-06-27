using RespApiProject2_Consumer.Models.Dtos;
using RespApiProject2_Consumer.Models.Dtos.DTOs;

namespace RespApiProject2_Consumer.Service.IService
{
    public interface IUserService
    {
        Task<T> loginAsync<T>(LoginRequestDTO  loginRequestDTO);
        Task<T> registerAsync<T>(RegisterRequestDTO registerRequestDTO);
 
    }
}
