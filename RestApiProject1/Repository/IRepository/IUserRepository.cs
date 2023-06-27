using Models;
using Models.DTOs;

namespace RestApiProject1.Repository.IRepository
{
    public interface IUserRepository<T> where T : class
    {
        public bool IsUnique(string email);
        public Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        public Task<ApplicationUser> Register( T applicationUser);
      

    }
}
