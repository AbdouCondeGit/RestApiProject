﻿//using AutoMapper;
//using Azure;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Models;
//using RestApiProject1.Repository.IRepository;
//using System.Data;
//using System.Net;

//namespace RestApiProject1.Controllers.v2
//{
//    public class VillaApiController
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;
//        //private readonly ILogger _logger;
//        protected ApiResponse _response;

//        public VillaApiController(IUnitOfWork unitOfWork, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//            _response = new();
//            //this._logger = logger;
//        }




//        [HttpGet]
//        [ResponseCache(CacheProfileName = "Default30")]
//        [ProducesResponseType(StatusCodes.Status403Forbidden)]
//        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        public async Task<ActionResult<ApiResponse>> GetVillas([FromQuery(Name = "filterOccupancy")] int? occupancy,
//            [FromQuery] string? search, int pageSize = 0, int pageNumber = 1)
//        {
//            try
//            {

//                IEnumerable<Villa> villaList;

//                if (occupancy > 0)
//                {
//                    villaList = await _unitOfWork.villaValueRepository.GetAllAsync(u => u.Occupancy == occupancy, pageSize: pageSize,
//                        pageNumber: pageNumber);
//                }
//                else
//                {
//                    villaList = await _unitOfWork.villaValueRepository.GetAllAsync(pageSize: pageSize,
//                        pageNumber: pageNumber);
//                }
//                if (!string.IsNullOrEmpty(search))
//                {
//                    villaList = villaList.Where(u => u.Name.ToLower().Contains(search));
//                }
//                Pagination pagination = new() { PageNumber = pageNumber, PageSize = pageSize };

//                Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(pagination));
//                _response.Result = _mapper.Map<List<VillaDTO>>(villaList);
//                _response.StatusCode = HttpStatusCode.OK;
//                return Ok(_response);

//            }
//            catch (Exception ex)
//            {
//                _response.IsSuccess = false;
//                _response.ErrorMessages
//                     = new List<string>() { ex.ToString() };
//            }
//            return _response;

//        }

//        [HttpGet("{id:int}", Name = "GetVilla")]
//        [ProducesResponseType(StatusCodes.Status403Forbidden)]
//        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        //[ProducesResponseType(200, Type =typeof(VillaDTO))]
//        //        [ResponseCache(Location =ResponseCacheLocation.None,NoStore =true)]
//        public async Task<ActionResult<APIResponse>> GetVilla(int id)
//        {
//            try
//            {
//                if (id == 0)
//                {
//                    _response.StatusCode = HttpStatusCode.BadRequest;
//                    return BadRequest(_response);
//                }
//                var villa = await _dbVilla.GetAsync(u => u.Id == id);
//                if (villa == null)
//                {
//                    _response.StatusCode = HttpStatusCode.NotFound;
//                    return NotFound(_response);
//                }
//                _response.Result = _mapper.Map<VillaDTO>(villa);
//                _response.StatusCode = HttpStatusCode.OK;
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                _response.IsSuccess = false;
//                _response.ErrorMessages
//                     = new List<string>() { ex.ToString() };
//            }
//            return _response;
//        }

//        [HttpPost]
//        [Authorize(Roles = "admin")]
//        [ProducesResponseType(StatusCodes.Status201Created)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
//        public async Task<ActionResult<APIResponse>> CreateVilla([FromBody] VillaCreateDTO createDTO)
//        {
//            try
//            {
//                //if (!ModelState.IsValid)
//                //{
//                //    return BadRequest(ModelState);
//                //}
//                if (await _dbVilla.GetAsync(u => u.Name.ToLower() == createDTO.Name.ToLower()) != null)
//                {
//                    ModelState.AddModelError("ErrorMessages", "Villa already Exists!");
//                    return BadRequest(ModelState);
//                }

//                if (createDTO == null)
//                {
//                    return BadRequest(createDTO);
//                }
//                //if (villaDTO.Id > 0)
//                //{
//                //    return StatusCode(StatusCodes.Status500InternalServerError);
//                //}
//                Villa villa = _mapper.Map<Villa>(createDTO);

//                //Villa model = new()
//                //{
//                //    Amenity = createDTO.Amenity,
//                //    Details = createDTO.Details,
//                //    ImageUrl = createDTO.ImageUrl,
//                //    Name = createDTO.Name,
//                //    Occupancy = createDTO.Occupancy,
//                //    Rate = createDTO.Rate,
//                //    Sqft = createDTO.Sqft
//                //};
//                await _dbVilla.CreateAsync(villa);
//                _response.Result = _mapper.Map<VillaDTO>(villa);
//                _response.StatusCode = HttpStatusCode.Created;
//                return CreatedAtRoute("GetVilla", new { id = villa.Id }, _response);
//            }
//            catch (Exception ex)
//            {
//                _response.IsSuccess = false;
//                _response.ErrorMessages
//                     = new List<string>() { ex.ToString() };
//            }
//            return _response;
//        }

//        [ProducesResponseType(StatusCodes.Status204NoContent)]
//        [ProducesResponseType(StatusCodes.Status403Forbidden)]
//        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
//        [ProducesResponseType(StatusCodes.Status404NotFound)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        [HttpDelete("{id:int}", Name = "DeleteVilla")]
//        [Authorize(Roles = "admin")]
//        public async Task<ActionResult<APIResponse>> DeleteVilla(int id)
//        {
//            try
//            {
//                if (id == 0)
//                {
//                    return BadRequest();
//                }
//                var villa = await _dbVilla.GetAsync(u => u.Id == id);
//                if (villa == null)
//                {
//                    return NotFound();
//                }
//                await _dbVilla.RemoveAsync(villa);
//                _response.StatusCode = HttpStatusCode.NoContent;
//                _response.IsSuccess = true;
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                _response.IsSuccess = false;
//                _response.ErrorMessages
//                     = new List<string>() { ex.ToString() };
//            }
//            return _response;
//        }
//        [Authorize(Roles = "admin")]
//        [HttpPut("{id:int}", Name = "UpdateVilla")]
//        [ProducesResponseType(StatusCodes.Status204NoContent)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        public async Task<ActionResult<APIResponse>> UpdateVilla(int id, [FromBody] VillaUpdateDTO updateDTO)
//        {
//            try
//            {
//                if (updateDTO == null || id != updateDTO.Id)
//                {
//                    return BadRequest();
//                }

//                Villa model = _mapper.Map<Villa>(updateDTO);

//                await _dbVilla.UpdateAsync(model);
//                _response.StatusCode = HttpStatusCode.NoContent;
//                _response.IsSuccess = true;
//                return Ok(_response);
//            }
//            catch (Exception ex)
//            {
//                _response.IsSuccess = false;
//                _response.ErrorMessages
//                     = new List<string>() { ex.ToString() };
//            }
//            return _response;
//        }

//        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
//        [ProducesResponseType(StatusCodes.Status204NoContent)]
//        [ProducesResponseType(StatusCodes.Status400BadRequest)]
//        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDTO)
//        {
//            if (patchDTO == null || id == 0)
//            {
//                return BadRequest();
//            }
//            var villa = await _dbVilla.GetAsync(u => u.Id == id, tracked: false);

//            VillaUpdateDTO villaDTO = _mapper.Map<VillaUpdateDTO>(villa);


//            if (villa == null)
//            {
//                return BadRequest();
//            }
//            patchDTO.ApplyTo(villaDTO, ModelState);
//            Villa model = _mapper.Map<Villa>(villaDTO);

//            await _dbVilla.UpdateAsync(model);

//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }
//            return NoContent();
//        }


//    }

//}
//}
