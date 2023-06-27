using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTOs;
using RestApiProject1.Repository.IRepository;
using System.Net;

namespace RestApiProject1.Controllers
{
    //[Route("api/UserApi")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserApiController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        //private readonly ILogger _logger;

        public UserApiController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
            //this._logger = logger;
        }



        //[HttpPost(Name = "Register")]
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ApiResponse>> Register([FromBody] RegisterRequestDTO registerRequestDTO)
        {
            ApiResponse apiResponse = new ApiResponse();
            if (_unitOfWork.userRepository.IsUnique(registerRequestDTO.Email) == false)
            {
                apiResponse.statusCode = System.Net.HttpStatusCode.Forbidden;
                apiResponse.ErrorMessage = new List<string> { "This email is already associated to a user in our database" };
                apiResponse.IsSuccess = false;
                apiResponse.result = null;
                return BadRequest(apiResponse);
            }
            apiResponse.result = _unitOfWork.userRepository.Register(_mapper.Map<ApplicationUser>(registerRequestDTO)).GetAwaiter().GetResult();
            if(apiResponse.result == null)
            {
                apiResponse.statusCode = HttpStatusCode.BadRequest;
                apiResponse.IsSuccess = false;
                apiResponse.ErrorMessage.Add("Error while registering");
                return BadRequest(apiResponse);
            }
            _unitOfWork.CommitAsync().GetAwaiter().GetResult();
            apiResponse.statusCode=System.Net.HttpStatusCode.OK;
            apiResponse.IsSuccess = true;
            return Ok(apiResponse);     
        }
        //[HttpPost(Name = "Login")]
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ApiResponse>> Login([FromBody] LoginRequestDTO loginRequestDTO)
        {
            ApiResponse apiResponse = new ApiResponse();
            LoginResponseDTO loginResponseDTO=_unitOfWork.userRepository.Login(loginRequestDTO).GetAwaiter().GetResult();
            if(loginResponseDTO == null ||loginResponseDTO.applicationUser==null ||loginResponseDTO.token==null)
            {
                apiResponse.statusCode = System.Net.HttpStatusCode.NetworkAuthenticationRequired;
                apiResponse.ErrorMessage = new List<string> { "Your credentials are not correct" };
                apiResponse.IsSuccess = false;
                apiResponse.result = null;
                return BadRequest(apiResponse);
            }
            apiResponse.result=loginResponseDTO;
            apiResponse.statusCode = System.Net.HttpStatusCode.OK;
            apiResponse.IsSuccess = true;
            return  Ok(apiResponse);

        }


    }
}
