using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ApiResponse
    {
        HttpStatusCode statusCode;
        bool IsSuccess=true;
        object result;
        public List<String> ErrorMessage { get; set; } = new List<String>();
    }
}
