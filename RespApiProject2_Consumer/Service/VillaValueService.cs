﻿using RespApiProject2_Consumer.Models;
using RespApiProject2_Consumer.Models.Dtos;
using RespApiProject2_Consumer.Models.Dtos.DTOs;
using RespApiProject2_Consumer.Service.IService;
using Utilities;

namespace RespApiProject2_Consumer.Service
{
    public class VillaValueService : BaseService, IVillaValueService
    {
        IConfiguration _configuration;
        private string baseUrlService;
        public VillaValueService(IHttpClientFactory httpClientFactory,IConfiguration configuration) : base(httpClientFactory)
        {
            _configuration = configuration;
            baseUrlService = _configuration.GetValue<String>("ServicesUrls:VillaApiService");
        }

        public Task<T> CreateVillaValueAsynca<T>(VillaValueCreateDTO villaValueCreateDTO)
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl = baseUrlService + "api/v1/VillaValue/CreateVillaValue",
                RequetPayload=villaValueCreateDTO,
                apiRequestType = ApiRequestVerb.POST,

            });
        }

        public Task<T> DeleteVillaValueAsync<T>(int id)
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl = baseUrlService + "api/v1/VillaValue/DeleteVillaValue/" + id,
                apiRequestType = ApiRequestVerb.DELETE,

            });
        }

        public Task<T> GetAllVillaValuesAsync<T>()
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl = baseUrlService + "api/v1/VillaValue/getVillaValues",
                apiRequestType = ApiRequestVerb.GET,

            });
        }

        public Task<T> GetVillaValueAsync<T>(int id)
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl=baseUrlService+ "api/v1/VillaValue/GetVillaValue/" + id,
                apiRequestType = ApiRequestVerb.GET,

            });
        }

        public Task<T> UpdateVillaValueAsync<T>(VillaValueUpdateDTO villaValueUpdateDTO)
        {
            return SendHttpRequestAsync<T>(new ApiRequest
            {
                baseUrl = baseUrlService + "api/v1/VillaValue/EditVilla",
                RequetPayload = villaValueUpdateDTO,
                apiRequestType = ApiRequestVerb.PUT,

            });
        }
    }
}
