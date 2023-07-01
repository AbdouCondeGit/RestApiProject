using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using RespApiProject2_Consumer.Models;
using RespApiProject2_Consumer.Models.Dtos;
using RespApiProject2_Consumer.Models.Dtos.DTOs;
using RespApiProject2_Consumer.Service;
using RespApiProject2_Consumer.Service.IService;
using System.Diagnostics;

namespace RespApiProject2_Consumer.Controllers
{
    public class VillaValueController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVillaValueService _villaValueService;
        IMapper _mapper;
        public VillaValueController(ILogger<HomeController> logger,IVillaValueService villaValueService,IMapper mapper)
        {
            _logger = logger;
            _villaValueService = villaValueService;
            _mapper = mapper;
        }

        public async Task<ActionResult<ApiResponse>> Index()
        {
            //List<VillaDTO> villas = new();
            ApiResponse response = _villaValueService.GetAllVillaValuesAsync<ApiResponse>().GetAwaiter().GetResult(); 
            if (response!=null && response.IsSuccess)
            {
               // villas = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.result));
                response.result = JsonConvert.DeserializeObject<List<VillaValueDTO>>(Convert.ToString(response.result));
               
            }
     
            return View(response.result);
        }


     public IActionResult Create()
        {
            return View();
        }

    [HttpPost]
    public async Task<ActionResult<ApiResponse>> Create(VillaValueCreateDTO villaValueCreateDTO)
    {
        //List<VillaDTO> villas = new();
        if(ModelState.IsValid)
            {
                ApiResponse response = _villaValueService.CreateVillaValueAsynca<ApiResponse>(villaValueCreateDTO).GetAwaiter().GetResult();
                if (response != null && response.IsSuccess)
                {
                    // villas = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.result));
                    response.statusCode = System.Net.HttpStatusCode.NoContent;
                    response.IsSuccess = true;
                    TempData["success"] = "Villa Value created successfully";
                    return RedirectToAction(nameof(Index));

                }
                else
                {
                    response.statusCode=System.Net.HttpStatusCode.BadRequest;
                    response.IsSuccess = false;
                    for(int i = 0; i < response.ErrorMessage.Count; i++)
                    {
						ModelState.AddModelError(response.ErrorMessage.ToString(), response.ErrorMessage[i]);
                        ModelState.AddModelError("Client side error", "Please make sure that that value you put for Villa Number does not already exist and the value for VillaId exists (see in villas list)");
					}
                    return View(villaValueCreateDTO);
                }
               
            }
            else { 
                return View(villaValueCreateDTO); 
            }
       
    }

      public async Task<IActionResult> Edit(int id)
		{
            ApiResponse apiResponse= _villaValueService.GetVillaValueAsync<ApiResponse>(id).GetAwaiter().GetResult();
            if(apiResponse!=null && apiResponse.IsSuccess)
            {
                VillaValueDTO model = JsonConvert.DeserializeObject<VillaValueDTO>(Convert.ToString(apiResponse.result));
                return View(_mapper.Map<VillaValueUpdateDTO>(model));
                //VillaUpdateDTO villaFromDb = _mapper.Map<VillaUpdateDTO>(apiResponse.result);
                //return View(villaFromDb);
            }
            return View();
            
		}

		[HttpPost]
		public async Task<ActionResult<ApiResponse>> Edit(VillaValueUpdateDTO villaValueUpdateDTO)
		{
			//List<VillaDTO> villas = new();
			if (ModelState.IsValid)
			{
				ApiResponse response = _villaValueService.UpdateVillaValueAsync<ApiResponse>(villaValueUpdateDTO).GetAwaiter().GetResult();
				if (response != null && response.IsSuccess)
				{
					// villas = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.result));
					response.statusCode = System.Net.HttpStatusCode.NoContent;
					response.IsSuccess = true;
                    TempData["success"] = "Villa Value updated successfully";
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
					return View(villaValueUpdateDTO);
				}

			}
			else
			{
				return View(villaValueUpdateDTO);
			}

		}

        //public async Task<IActionResult> Delete(int id)
        //{
        //    ApiResponse apiResponse = _villaValueService.GetVillaValueAsync<ApiResponse>(id).GetAwaiter().GetResult();
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
          
        //        ApiResponse response = _villaValueService.DeleteVillaValueAsync<ApiResponse>(villaUpdateDTO.Id).GetAwaiter().GetResult();
        //        if (response != null && response.IsSuccess)
        //        {
        //            // villas = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.result));
        //            response.statusCode = System.Net.HttpStatusCode.NoContent;
        //            response.IsSuccess = true;
        //            return RedirectToAction(nameof(Index));

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
        public async Task<ActionResult<IEnumerable<VillaValueDTO>>> getAllVillaValues()
        {
            ApiResponse response = _villaValueService.GetAllVillaValuesAsync<ApiResponse>().GetAwaiter().GetResult();
            if (response != null && response.IsSuccess)
            {
                // villas = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.result));
                response.result = JsonConvert.DeserializeObject<List<VillaValueDTO>>(Convert.ToString(response.result));

            }

            //return View(response.result);
            return Json(new { data = response.result });

        }


        [HttpDelete]
        public async Task<IActionResult> DeleteVillaValue(int id)
        {
            ApiResponse apiResponse = _villaValueService.GetVillaValueAsync<ApiResponse>(id).GetAwaiter().GetResult();
            if (apiResponse != null && apiResponse.IsSuccess)
            {
                ApiResponse response = _villaValueService.DeleteVillaValueAsync<ApiResponse>(id).GetAwaiter().GetResult();
                return Json(new { success = true, message = "Delete Successful" });
            }
            return Json(new { success = false, message = "Error while deleting" });

        }

        #endregion

    }

}