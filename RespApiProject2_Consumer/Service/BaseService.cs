using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RespApiProject2_Consumer.Models;
using RespApiProject2_Consumer.Service.IService;
using System.Text;
using Utilities;

namespace RespApiProject2_Consumer.Service
{
    public class BaseService : IBaseService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ApiResponse apiResponse { get; set; }
        public BaseService(IHttpClientFactory httpClientFactory)
        {
            apiResponse = new ApiResponse();
            _httpClientFactory = httpClientFactory;
        }
        public async Task<T> SendHttpRequestAsync<T>(ApiRequest apiRequest)
        {
            try
            {
                HttpClient client = _httpClientFactory.CreateClient();
                HttpRequestMessage message = new HttpRequestMessage();
                message.RequestUri = new Uri(apiRequest.baseUrl);
                message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.RequetPayload), Encoding.UTF8, "application/json");
                switch (apiRequest.apiRequestType)
                {
                    case ApiRequestVerb.GET:
                        message.Method = HttpMethod.Get;
                        break;
                    case ApiRequestVerb.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case ApiRequestVerb.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case ApiRequestVerb.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;

                }

                HttpResponseMessage responseMessage = client.SendAsync(message).GetAwaiter().GetResult();
                String responseContent = responseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                T response = JsonConvert.DeserializeObject<T>(responseContent);
                return response;


            }
            catch (Exception ex)
            {
                ApiResponse apiResponse = new ApiResponse
                {
                    IsSuccess = false,
                    statusCode = System.Net.HttpStatusCode.BadRequest,
                    ErrorMessage = new List<string> { ex.Message },
                    result = null

                };
                var responseContent = JsonConvert.SerializeObject(apiResponse);
                T response = JsonConvert.DeserializeObject<T>(responseContent);
                return response;
            }
        }
    }
}
