using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using RespApiProject2_Consumer.Models;
using RespApiProject2_Consumer.Models.Dtos;
using RespApiProject2_Consumer.Models.Dtos.DTOs;
using RespApiProject2_Consumer.Service;
using RespApiProject2_Consumer.Service.IService;
using System.Data;
using System.Diagnostics;
using Utilities;

namespace RespApiProject2_Consumer.Controllers
{
    public class VillaController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVillaService _villaService;
        IMapper _mapper;
        public VillaController(ILogger<HomeController> logger,IVillaService villaService,IMapper mapper)
        {
            _logger = logger;
            _villaService = villaService;
            _mapper = mapper;
        }

        public async Task<ActionResult<ApiResponse>> Index()
        {
            //List<VillaDTO> villas = new();
            ApiResponse response = _villaService.GetAllVillasAsync<ApiResponse>().GetAwaiter().GetResult(); 
            if (response!=null && response.IsSuccess)
            {
               // villas = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.result));
                response.result = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.result));
                return View(response.result);
            }
     
            return View();
        }

        [Authorize(Roles = PossibleRoles.Role_Admin)]
        public IActionResult Create()
        {
            return View();
        }

    [HttpPost]
    public async Task<ActionResult<ApiResponse>> Create(VillaCreateDTO villaCreateDTO)
    {
        //List<VillaDTO> villas = new();
        if(ModelState.IsValid)
            {
                ApiResponse response = _villaService.CreateVillAsynca<ApiResponse>(villaCreateDTO).GetAwaiter().GetResult();
                if (response != null && response.IsSuccess)
                {
                    // villas = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.result));
                    response.statusCode = System.Net.HttpStatusCode.NoContent;
                    response.IsSuccess = true;
                    TempData["success"] = "Villa created successfully";
                    return RedirectToAction(nameof(Index));

                }
                else
                {
                    response.statusCode=System.Net.HttpStatusCode.BadRequest;
                    response.IsSuccess = false;
                    for(int i = 0; i < response.ErrorMessage.Count; i++)
                    {
						ModelState.AddModelError(response.ErrorMessage.ToString(), response.ErrorMessage[i]);
					}
                    return View(villaCreateDTO);
                }
               
            }
            else { 
                return View(villaCreateDTO); 
            }
       
    }
        [Authorize(Roles = PossibleRoles.Role_Admin)]
        public async Task<IActionResult> Edit(int id)
		{
            ApiResponse apiResponse=_villaService.GetVillaAsync<ApiResponse>(id).GetAwaiter().GetResult();
            if(apiResponse!=null && apiResponse.IsSuccess)
            {
                VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(apiResponse.result));
                return View(_mapper.Map<VillaUpdateDTO>(model));
                //VillaUpdateDTO villaFromDb = _mapper.Map<VillaUpdateDTO>(apiResponse.result);
                //return View(villaFromDb);
            }
            return NotFound();
            
		}

		[HttpPost]
		public async Task<ActionResult<ApiResponse>> Edit(VillaUpdateDTO villaUpdateDTO)
		{
			//List<VillaDTO> villas = new();
			if (ModelState.IsValid)
			{
				ApiResponse response = _villaService.UpdateVillaAsync<ApiResponse>(villaUpdateDTO).GetAwaiter().GetResult();
				if (response != null && response.IsSuccess)
				{
					// villas = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.result));
					response.statusCode = System.Net.HttpStatusCode.NoContent;
					response.IsSuccess = true;
                    TempData["success"] = "Villa updated successfully";
                    return RedirectToAction(nameof(Index));

				}
				else
				{
					response.statusCode = System.Net.HttpStatusCode.BadRequest;
					response.IsSuccess = false;
					for (int i = 0; i < response.ErrorMessage.Count; i++)
					{
						ModelState.AddModelError(response.ErrorMessage.ToString(), response.ErrorMessage[i]);
					}
					return View(villaUpdateDTO);
				}

			}
			else
			{
				return View(villaUpdateDTO);
			}

		}

        //public async Task<IActionResult> Delete(int id)
        //{
        //    ApiResponse apiResponse = _villaService.GetVillaAsync<ApiResponse>(id).GetAwaiter().GetResult();
        //    if (apiResponse != null && apiResponse.IsSuccess)
        //    {
        //        VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(apiResponse.result));
        //        return View(_mapper.Map<VillaUpdateDTO>(model));
        //        //VillaUpdateDTO villaFromDb = _mapper.Map<VillaUpdateDTO>(apiResponse.result);
        //        //return View(villaFromDb);
        //    }
        //    return NotFound();

        //}

        //[HttpPost]
        //public async Task<ActionResult<ApiResponse>> Delete(VillaUpdateDTO villaUpdateDTO)
        //{

        //        ApiResponse response = _villaService.DeleteVillaAsync<ApiResponse>(villaUpdateDTO.Id).GetAwaiter().GetResult();
        //        if (response != null && response.IsSuccess)
        //        {
        //            // villas = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.result));
        //            response.statusCode = System.Net.HttpStatusCode.NoContent;
        //            response.IsSuccess = true;
        //        TempData["success"] = "Villa deleted successfully";
        //        return RedirectToAction(nameof(Index));

        //        }
        //        else
        //        {
        //            response.statusCode = System.Net.HttpStatusCode.BadRequest;
        //            response.IsSuccess = false;
        //            for (int i = 0; i < response.ErrorMessage.Count; i++)
        //            {
        //                ModelState.AddModelError(response.ErrorMessage.ToString(), response.ErrorMessage[i]);
        //            }
        //            return View(villaUpdateDTO);
        //        }

        //}


        #region ApiCalls

        public async Task<ActionResult<IEnumerable<VillaValueDTO>>> getVillasList()
        {
            ApiResponse response = _villaService.GetAllVillasAsync<ApiResponse>().GetAwaiter().GetResult();
            if (response != null && response.IsSuccess)
            {
                // villas = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.result));
                response.result = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.result));
                return Json(new { data = response.result });

            }

            //return View(response.result);
            return Json(new { data = new ApiResponse { result=new VillaDTO() } });
        

        }


        [HttpDelete]
        public async Task<IActionResult> DeleteVilla(int id)
        {
            ApiResponse apiResponse = _villaService.GetVillaAsync<ApiResponse>(id).GetAwaiter().GetResult();
            if (apiResponse != null && apiResponse.IsSuccess)
            {
                ApiResponse response = _villaService.DeleteVillaAsync<ApiResponse>(id).GetAwaiter().GetResult();
                return Json(new { success = true, message = "Delete Successful" });
            }
            return Json(new { success = false, message = "Error while deleting" });
            
        }


        #endregion

    }

}