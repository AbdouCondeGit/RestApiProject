using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using Models;
using Models.DTOs;
using RestApiProject1.Repository.IRepository;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using Utilities;


namespace RestApiProject1.Repository
{
    public class UserRepository :IUserRepository<ApplicationUser>
    {
        private readonly ApplicationDbContext _db;
        TokenSecretKey _tokenSecretKey;
        string secretKey;
        public UserRepository(ApplicationDbContext db,IConfiguration configuration)
        {
            this._db = db;
            _tokenSecretKey = new TokenSecretKey();
            secretKey= configuration.GetValue<string>("TokenAuth:Tokenkey");

        }

        public bool IsUnique(string email)
        {
            var userFromDb=_db.ApplicationUsers.FirstOrDefaultAsync(x => x.Email.ToLower() == email.ToLower()).GetAwaiter().GetResult();
            return userFromDb==null;
        }

        public async Task<ApplicationUser> Register(ApplicationUser applicationUser)
        {
            _db.ApplicationUsers.AsNoTracking();
            _db.ApplicationUsers.AddAsync(applicationUser).GetAwaiter().GetResult();
            ApplicationUser applicationUser1=new ApplicationUser
            {
                Username=applicationUser.Username,
                Email=applicationUser.Email,
                Password = ""
            };
            return applicationUser1;
        }
        public async Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
        {
            var userFromDb = _db.ApplicationUsers.FirstOrDefaultAsync(x => x.Username.ToLower() == loginRequestDTO.Username.ToLower() && x.Password.ToLower()==loginRequestDTO.Password.ToLower()).GetAwaiter().GetResult();
            if(userFromDb==null)
            {
                return null;
            }
            var keyEncrypted = Encoding.ASCII.GetBytes(secretKey);
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userFromDb.Username.ToString()),
                    new Claim(ClaimTypes.Role, userFromDb.Role)
                }
                ),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new(new SymmetricSecurityKey(keyEncrypted), SecurityAlgorithms.HmacSha256Signature)
            };

            var token=jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
            LoginResponseDTO loginResponseDTO = new LoginResponseDTO()
            {
                applicationUser = userFromDb,
                token = jwtSecurityTokenHandler.WriteToken(token)
            };
            return loginResponseDTO;
        }
    }
}
