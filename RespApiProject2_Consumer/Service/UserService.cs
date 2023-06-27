using RespApiProject2_Consumer.Models;
using RespApiProject2_Consumer.Models.Dtos;
using RespApiProject2_Consumer.Models.Dtos.DTOs;
using RespApiProject2_Consumer.Service.IService;
using Utilities;

namespace RespApiProject2_Consumer.Service
{
    public class UserService : BaseService, IUserService
    {
        IConfiguration _configuration;
        private string baseUrlService;
        public UserService(IHttpClientFactory httpClientFactory,IConfiguration configuration) : base(httpClientFactory)
        {
            _configuration = configuration;
            baseUrlService = _configuration.GetValue<String>("ServicesUrls:VillaApiService");
        }

        public Task<T> loginAsync<T>(LoginRequestDTO loginRequestDTO)
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl = baseUrlService + "api/UserApi/Login",
                RequetPayload= loginRequestDTO,
                apiRequestType = ApiRequestVerb.POST,

            });
        }
        public Task<T> registerAsync<T>(RegisterRequestDTO registerRequestDTO)
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl = baseUrlService + "api/UserApi/Register",
                RequetPayload = registerRequestDTO,
                apiRequestType = ApiRequestVerb.POST,

            });
        }
    }
}
