using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class LoginResponseDTO
    {
        public ApplicationUser applicationUser { get; set; }
        public string token { get; set; }
    }
}
