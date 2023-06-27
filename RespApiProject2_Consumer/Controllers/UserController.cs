using Azure;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using RespApiProject2_Consumer.Models;
using RespApiProject2_Consumer.Models.Dtos;
using RespApiProject2_Consumer.Service;
using RespApiProject2_Consumer.Service.IService;
using System.Diagnostics;
using System.Security.Claims;
using Utilities;
using Jose;

namespace RespApiProject2_Consumer.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<HomeController> logger,IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequestDTO loginRequestDTO)
        {
            if (ModelState.IsValid) { 
            ApiResponse apiResponse = _userService.loginAsync<ApiResponse>(loginRequestDTO).GetAwaiter().GetResult();
            if (apiResponse != null && apiResponse.IsSuccess) {
                LoginResponseDTO loginResponseDTO = JsonConvert.DeserializeObject<LoginResponseDTO>(Convert.ToString(apiResponse.result));
                if(loginResponseDTO != null)
                {
                        var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                        identity.AddClaim(new Claim(ClaimTypes.Name, loginResponseDTO.applicationUser.Username));
                        identity.AddClaim(new Claim(ClaimTypes.Role, loginResponseDTO.applicationUser.Role));
                        var principal = new ClaimsPrincipal(identity);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        HttpContext.Session.SetString(SD.token, loginResponseDTO.token);
                   
                        return RedirectToAction("Index", "Home");
                }
                    return View(loginRequestDTO);

                }
                for (int i = 0; i < apiResponse.ErrorMessage.Count; i++)
                {
                    ModelState.AddModelError(apiResponse.ErrorMessage.ToString(), apiResponse.ErrorMessage[i]);
                }

                return View(loginRequestDTO);
            }
           
            return View(loginRequestDTO);
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.SetString(SD.token, "") ;
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Register()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterRequestDTO registerRequestDTO)
        {
          
            if(ModelState.IsValid) { 
            ApiResponse apiResponse = _userService.registerAsync<ApiResponse>(registerRequestDTO).GetAwaiter().GetResult();
            if (apiResponse != null && apiResponse.IsSuccess)
            {
                return RedirectToAction("Index", "Home");
            }
                for (int i = 0; i < apiResponse.ErrorMessage.Count; i++)
                {
                    ModelState.AddModelError(apiResponse.ErrorMessage.ToString(), apiResponse.ErrorMessage[i]);
                }
                return View(registerRequestDTO);
            }

            return View(registerRequestDTO);
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}