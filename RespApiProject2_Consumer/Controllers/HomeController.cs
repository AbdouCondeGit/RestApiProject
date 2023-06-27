using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RespApiProject2_Consumer.Models;
using RespApiProject2_Consumer.Models.Dtos;
using RespApiProject2_Consumer.Service;
using RespApiProject2_Consumer.Service.IService;
using System.Diagnostics;
using Utilities;

namespace RespApiProject2_Consumer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVillaService _villaService;

        public HomeController(ILogger<HomeController> logger,IVillaService villaService)
        {
            _logger = logger;
            _villaService = villaService;
        }

        public async Task<ActionResult<ApiResponse>> Index()
        {
            //List<VillaDTO> villas = new();
            ApiResponse response = _villaService.GetAllVillasAsync<ApiResponse>(HttpContext.Session.GetString(SD.token)).GetAwaiter().GetResult();
            if (response != null && response.IsSuccess)
            {
                // villas = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.result));
                response.result = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.result));
                return View(response.result);
            }
            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}