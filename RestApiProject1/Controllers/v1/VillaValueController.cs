using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTOs;
using RestApiProject1.Repository.IRepository;
using System.Data;
namespace RestApiProject1.Controllers.v1
{
    //[Route("api/[VillaValue]")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    //[Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0",Deprecated =true)]
    [ApiVersion("2.0")]
    public class VillaValueController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        //private readonly ILogger _logger;

        public VillaValueController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            //this._logger = logger;
        }
        [HttpGet]
        [ProducesResponseType(404)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> getVillaValues()
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var villas = await _unitOfWork.villaValueRepository.GetAllAsync(1,1,"Villa");
                if (villas == null)
                {
                    return NotFound();
                }
                apiResponse.IsSuccess = true;
                apiResponse.statusCode = System.Net.HttpStatusCode.OK;
                apiResponse.result = _mapper.Map<List<VillaValueDTO>>(villas);
                apiResponse.ErrorMessage = null;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                apiResponse.IsSuccess = false;
                apiResponse.ErrorMessage = new List<string> { ex.Message.ToString() };
                return BadRequest(apiResponse);
            }

        }

        [HttpGet("getValuesv2")]
        [ProducesResponseType(404)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [MapToApiVersion("2.0")]
        public async Task<ActionResult<object>> getVillaValues_2()
        {
            return new { success = true, failure = false };

        }

        [HttpGet("{id:int}", Name = "GetVillaValue")]
        [ProducesResponseType(404)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ApiResponse>> getVillaValue(int? id)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var villa = await _unitOfWork.villaValueRepository.getAsync(u => u.VillaNo == id, false, "Villa");
                if (villa == null)
                {
                    apiResponse.statusCode = System.Net.HttpStatusCode.NotFound;
                    apiResponse.IsSuccess = false;
                    return NotFound(apiResponse);
                }
                apiResponse.IsSuccess = true;
                apiResponse.statusCode = System.Net.HttpStatusCode.OK;
                apiResponse.result = _mapper.Map<VillaValueDTO>(villa);
                apiResponse.ErrorMessage = null;
                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                apiResponse.IsSuccess = false;
                apiResponse.ErrorMessage = new List<string> { ex.Message.ToString() };
                return BadRequest(apiResponse);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ResponseCache(Duration=30)]
        [ResponseCache(CacheProfileName = "Default30")]
        public async Task<ActionResult<ApiResponse>> CreateVillaValue([FromBody] VillaValueCreateDTO villaValue)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                if (villaValue == null || villaValue.SpecialDetails==null)
                {
                    apiResponse.statusCode = System.Net.HttpStatusCode.NotFound;
                    apiResponse.IsSuccess = false;
                    apiResponse.ErrorMessage = new List<string> {  "Yous muster enter at least three details separated by commas" };
                    return BadRequest(apiResponse);
                }
                if (villaValue.SpecialDetails.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length < 3)
                {
                    ModelState.AddModelError("CustomError", "Yous muster enter at least three details separated by commas");
                    apiResponse.statusCode = System.Net.HttpStatusCode.InternalServerError;
                    apiResponse.ErrorMessage.Add("ERROR: Yous muster enter at least three details separated by commas");
                    apiResponse.IsSuccess = false;
                    return BadRequest(apiResponse);
                }
                VillaValue myVilla = _mapper.Map<VillaValue>(villaValue);
                apiResponse.IsSuccess = true;
                apiResponse.statusCode = System.Net.HttpStatusCode.Created;
                apiResponse.result = _mapper.Map<VillaValueDTO>(myVilla);
                apiResponse.ErrorMessage = null;
                await _unitOfWork.villaValueRepository.CreateAsync(myVilla);
                await _unitOfWork.CommitAsync();
                return CreatedAtRoute("GetVillaValue", new { id = myVilla.VillaNo }, apiResponse);
            }
            catch (Exception ex)
            {
                apiResponse.IsSuccess = false;
                apiResponse.ErrorMessage = new List<string> { ex.Message.ToString() };
                return BadRequest(apiResponse);
            }


        }
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApiResponse>> EditVilla([FromBody] VillaValueUpdateDTO villaUpdateDTO)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                if (villaUpdateDTO == null || villaUpdateDTO.VillaNo == 0)
                {
                    apiResponse.statusCode = System.Net.HttpStatusCode.NotFound;
                    apiResponse.IsSuccess = false;
                    return BadRequest(apiResponse);
                }
                VillaValue villa = _unitOfWork.villaValueRepository.getAsync(u => u.VillaNo == villaUpdateDTO.VillaNo, false).GetAwaiter().GetResult();
                if (villa == null)
                {
                    apiResponse.statusCode = System.Net.HttpStatusCode.NotFound;
                    apiResponse.IsSuccess = false;
                    return NotFound(apiResponse);
                }
                villa = _mapper.Map<VillaValue>(villaUpdateDTO);
                _unitOfWork.villaValueRepository.UpdateAsync(villa).GetAwaiter().GetResult();
                await _unitOfWork.CommitAsync();
                apiResponse.IsSuccess = true;
                apiResponse.statusCode = System.Net.HttpStatusCode.NoContent;
                apiResponse.ErrorMessage = null;
                return Ok(apiResponse);

            }
            catch (Exception ex)
            {
                apiResponse.IsSuccess = false;
                apiResponse.ErrorMessage = new List<string> { ex.Message.ToString() };
                return BadRequest(apiResponse);
            }


        }
        [HttpDelete("{id:int}", Name = "DeleteVillaValue")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteVillaValue(int id)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                if (id == 0)
                {
                    apiResponse.statusCode = System.Net.HttpStatusCode.BadRequest;
                    apiResponse.IsSuccess = false;
                    return BadRequest(apiResponse);
                }
                var villa = await _unitOfWork.villaValueRepository.getAsync(u => u.VillaNo == id);
                if (villa == null)
                {
                    apiResponse.statusCode = System.Net.HttpStatusCode.NotFound;
                    apiResponse.IsSuccess = false;
                    return BadRequest(apiResponse);
                }
                await _unitOfWork.villaValueRepository.RemoveAsync(villa);
                await _unitOfWork.CommitAsync();
                apiResponse.IsSuccess = true;
                apiResponse.statusCode = System.Net.HttpStatusCode.NoContent;
                apiResponse.ErrorMessage = null;
                return Ok(apiResponse);

            }
            catch (Exception ex)
            {
                apiResponse.IsSuccess = false;
                apiResponse.ErrorMessage = new List<string> { ex.Message.ToString() };
                return BadRequest(apiResponse);
            }
        }
    }
}
