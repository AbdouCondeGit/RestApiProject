using RespApiProject2_Consumer.Models;
using RespApiProject2_Consumer.Models.Dtos;
using RespApiProject2_Consumer.Models.Dtos.DTOs;
using RespApiProject2_Consumer.Service.IService;
using Utilities;

namespace RespApiProject2_Consumer.Service
{
    public class VillaService : BaseService, IVillaService
    {
        IConfiguration _configuration;
        private string baseUrlService;
        public VillaService(IHttpClientFactory httpClientFactory,IConfiguration configuration) : base(httpClientFactory)
        {
            _configuration = configuration;
            baseUrlService = _configuration.GetValue<String>("ServicesUrls:VillaApiService");
        }

        public Task<T> CreateVillAsynca<T>(VillaCreateDTO villaCreateDTO,string token)
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl = baseUrlService + "api/v1/VillaApi",
                RequetPayload=villaCreateDTO,
                apiRequestType = ApiRequestVerb.POST,
                token = token

            });
        }

        public Task<T> DeleteVillaAsync<T>(int id, string token)
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl = baseUrlService + "api/v1/VillaApi/" + id,
                apiRequestType = ApiRequestVerb.DELETE,
                token = token

            });
        }

        public Task<T> GetAllVillasAsync<T>(string token)
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl = baseUrlService + "api/v1/VillaApi",
                apiRequestType = ApiRequestVerb.GET,
                token = token

            });
        }

        public Task<T> GetVillaAsync<T>(int id, string token)
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl=baseUrlService+ "api/v1/VillaApi/" + id,
                apiRequestType = ApiRequestVerb.GET,
                token=token
            });
        }

        public Task<T> UpdateVillaAsync<T>(VillaUpdateDTO villaUpdateDTO, string token)
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl = baseUrlService + "api/v1/VillaApi",
                RequetPayload = villaUpdateDTO,
                apiRequestType = ApiRequestVerb.PUT,
                token = token   

            });
        }
    }
}
