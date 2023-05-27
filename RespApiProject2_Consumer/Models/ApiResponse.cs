using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RespApiProject2_Consumer.Models
{
    public class ApiResponse
    {
        public HttpStatusCode statusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public object result { get; set; }
        public List<String> ErrorMessage { get; set; } = new List<String>();
    }
}
