

namespace RespApiProject2_Consumer.Models.Dtos
{
    public class LoginResponseDTO
    {
        public ApplicationUserDTO applicationUser { get; set; }
        public string token { get; set; }
    }
}
