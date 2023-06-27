using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace RespApiProject2_Consumer.Models
{
    public class ApiRequest
    {
        public ApiRequestVerb apiRequestType;
        public String baseUrl;
        public object RequetPayload;

    }
}
