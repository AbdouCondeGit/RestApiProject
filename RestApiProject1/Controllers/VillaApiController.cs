﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTOs;
using RestApiProject1.Repository.IRepository;

namespace RestApiProject1.Controllers
{
    //[Route("api/[VillaApi]")]
    [Route("api/[controller]")]
    [ApiController]
    public class VillaApiController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        //private readonly ILogger _logger;

        public VillaApiController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
            //this._logger = logger;
        }
        [HttpGet]
        [ProducesResponseType(404)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApiResponse>> getMagicVillas()
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var villas = await _unitOfWork.villaRepository.GetAllAsync();
                if (villas == null)
                {
                    return NotFound();
                }
                apiResponse.IsSuccess = true;
                apiResponse.statusCode = System.Net.HttpStatusCode.OK;
                apiResponse.result = (_mapper.Map<List<VillaDTO>>(villas));
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

        [HttpGet("{id:int}", Name = "GetVilla")]
        [ProducesResponseType(404)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ApiResponse>> getMagicVilla(int? id)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                var villa = await _unitOfWork.villaRepository.getAsync(u => u.Id == id);
                if (villa == null)
                {
                    apiResponse.statusCode = System.Net.HttpStatusCode.NotFound;
                    apiResponse.IsSuccess = false;
                    return NotFound(apiResponse);
                }
                apiResponse.IsSuccess = true;
                apiResponse.statusCode = System.Net.HttpStatusCode.OK;
                apiResponse.result = (_mapper.Map<VillaDTO>(villa));
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
        public async Task<ActionResult<ApiResponse>> CreateVilla([FromBody] VillaCreateDTO villa)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                if (villa == null)
                {
                    apiResponse.statusCode = System.Net.HttpStatusCode.NotFound;
                    apiResponse.IsSuccess = false;
                    return BadRequest(apiResponse);
                }
                if (villa.Details.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length < 3)
                {
                    ModelState.AddModelError("CustomError", "Yous muster enter at least three details separated by commas");
                    apiResponse.statusCode = System.Net.HttpStatusCode.InternalServerError;
                    apiResponse.ErrorMessage.Add("ERROR: Yous muster enter at least three details separated by commas");
                    apiResponse.IsSuccess = false;
                    return BadRequest(apiResponse);
                }
                Villa myVilla = _mapper.Map<Villa>(villa);
                apiResponse.IsSuccess = true;
                apiResponse.statusCode = System.Net.HttpStatusCode.Created;
                apiResponse.result = (myVilla);
                apiResponse.ErrorMessage = null;
                await _unitOfWork.villaRepository.CreateAsync(myVilla);
                await _unitOfWork.CommitAsync();
                return CreatedAtRoute("GetVilla", new { id = myVilla.Id }, apiResponse);
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
        public async Task<ActionResult<ApiResponse>> EditVilla([FromBody] VillaUpdateDTO villaUpdateDTO)
        {
            ApiResponse apiResponse = new ApiResponse();
            try
            {
                if (villaUpdateDTO == null || villaUpdateDTO.Id == 0)
                {
                    apiResponse.statusCode = System.Net.HttpStatusCode.NotFound;
                    apiResponse.IsSuccess = false;
                    return BadRequest(apiResponse);
                }
                Villa villa = _unitOfWork.villaRepository.getAsync(u => u.Id == villaUpdateDTO.Id, false).GetAwaiter().GetResult();
                if (villa == null)
                {
                    apiResponse.statusCode = System.Net.HttpStatusCode.NotFound;
                    apiResponse.IsSuccess = false;
                    return NotFound(apiResponse);
                }
                villa = _mapper.Map<Villa>(villaUpdateDTO);
                _unitOfWork.villaRepository.UpdateAsync(villa).GetAwaiter().GetResult();
                await _unitOfWork.CommitAsync();
                apiResponse.IsSuccess = true;
                apiResponse.ErrorMessage = null;
                apiResponse.statusCode = System.Net.HttpStatusCode.NoContent;
                return Ok(apiResponse);

            }
            catch (Exception ex)
            {
                apiResponse.IsSuccess = false;
                apiResponse.ErrorMessage = new List<string> { ex.Message.ToString() };
                return BadRequest(apiResponse);
            }


        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteVilla(int id)
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
                var villa = await _unitOfWork.villaRepository.getAsync(u => u.Id == id);
                if (villa == null)
                {
                    apiResponse.statusCode = System.Net.HttpStatusCode.NotFound;
                    apiResponse.IsSuccess = false;
                    return BadRequest(apiResponse);
                }
                await _unitOfWork.villaRepository.RemoveAsync(villa);
                await _unitOfWork.CommitAsync();
                apiResponse.IsSuccess = true;
                apiResponse.ErrorMessage = null;
                apiResponse.statusCode = System.Net.HttpStatusCode.NoContent;
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
