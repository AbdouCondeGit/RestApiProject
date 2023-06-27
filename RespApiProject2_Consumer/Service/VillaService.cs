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

        public Task<T> CreateVillAsynca<T>(VillaCreateDTO villaCreateDTO)
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl = baseUrlService + "api/VillaApi",
                RequetPayload=villaCreateDTO,
                apiRequestType = ApiRequestVerb.POST,

            });
        }

        public Task<T> DeleteVillaAsync<T>(int id)
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl = baseUrlService + "api/VillaApi/" + id,
                apiRequestType = ApiRequestVerb.DELETE,

            });
        }

        public Task<T> GetAllVillasAsync<T>()
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl = baseUrlService + "api/VillaApi",
                apiRequestType = ApiRequestVerb.GET,

            });
        }

        public Task<T> GetVillaAsync<T>(int id)
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl=baseUrlService+ "api/VillaApi/"+id,
                apiRequestType = ApiRequestVerb.GET,

            });
        }

        public Task<T> UpdateVillaAsync<T>(VillaUpdateDTO villaUpdateDTO)
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl = baseUrlService + "api/VillaApi",
                RequetPayload = villaUpdateDTO,
                apiRequestType = ApiRequestVerb.PUT,

            });
        }
    }
}
