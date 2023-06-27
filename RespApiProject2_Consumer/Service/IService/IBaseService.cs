using RespApiProject2_Consumer.Models;

namespace RespApiProject2_Consumer.Service.IService
{
    public interface IBaseService
    {
        public ApiResponse apiResponse { get; set; }
        public Task<T> SendHttpRequestAsync<T>(ApiRequest apiRequest);

    }
}
