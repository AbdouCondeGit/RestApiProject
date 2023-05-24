using AutoMapper;
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

        public VillaApiController(IUnitOfWork unitOfWork, IMapper mapper) {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
            //this._logger = logger;
        }
        [HttpGet]
        [ProducesResponseType(404)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<VillaDTO>>> getMagicVillas()
        {
            var villas = await _unitOfWork.villaRepository.GetAllAsync();
            if (villas == null)
            {
                return NotFound();
            }
            //using(StreamWriter fichier = new StreamWriter(@"/RestApiProject1/fichier1.txt"))
            //{ 
            //    Console.SetOut(fichier);
            //    Console.WriteLine("En train de retourner la liste de toutes les villas");
            //}
            return Ok(_mapper.Map<List<VillaDTO>>(villas));
        }

        [HttpGet("{id:int}", Name ="GetVilla")]
        [ProducesResponseType(404)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<VillaDTO>> getMagicVilla(int? id)
        {
            var villa = await _unitOfWork.villaRepository.getAsync(u=>u.Id==id);
            if (villa == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<VillaDTO>(villa));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<VillaDTO>> CreateVilla([FromBody] VillaCreateDTO villa)
        {
            if (villa == null)
            {
                return BadRequest();
            }
            if (villa.Details.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length < 3)
            {
                ModelState.AddModelError("CustomError", "Yous muster enter at least three details separated by commas");
                 return StatusCode(StatusCodes.Status500InternalServerError);
            }
            Villa myVilla=_mapper.Map<Villa>(villa);
            await _unitOfWork.villaRepository.CreateAsync(myVilla);
            await _unitOfWork.CommitAsync();
            return CreatedAtRoute("GetVilla",new { id=myVilla.Id }, myVilla);

        }
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> EditVilla([FromBody] VillaUpdateDTO villaUpdateDTO) { 
        
            if (villaUpdateDTO == null ||villaUpdateDTO.Id==0) {
                return BadRequest(villaUpdateDTO);    
            }
           Villa villa=_unitOfWork.villaRepository.getAsync(u=>u.Id == villaUpdateDTO.Id,false).GetAwaiter().GetResult();
            if (villa == null){
                return NotFound(villaUpdateDTO);
            }
            villa=_mapper.Map<Villa>(villaUpdateDTO);
            _unitOfWork.villaRepository.UpdateAsync(villa).GetAwaiter().GetResult();
            await _unitOfWork.CommitAsync();
            return NoContent();
                   
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = await _unitOfWork.villaRepository.getAsync(u => u.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            await _unitOfWork.villaRepository.RemoveAsync(villa);
            await _unitOfWork.CommitAsync();
            return NoContent();
        }


    }
}
