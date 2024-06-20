using APIRest.Responses;
using Core.DTOs.Carreras;
using Core.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace APIRest.Controllers
{
    [Route("api/carreras")]
    [ApiController]
    public class CarrerasController : ControllerBase
    {
        private readonly ICarreraService _carreraService;

        public CarrerasController(ICarreraService carreraService)
        {
            _carreraService = carreraService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var carreras = await _carreraService.GetAllCarrerasAsync();
            return Ok(new ApiResponse<IEnumerable<CarreraDto>>(carreras));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var carrera = await _carreraService.GetCarreraByIdAsync(id);
            if (carrera == null)
            {
                return NotFound();
            }
            return Ok(new ApiResponse<CarreraDto>(carrera));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCarreraDto createCarreraDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var carrera = await _carreraService.CreateCarreraAsync(createCarreraDto);
            return CreatedAtAction(nameof(GetById), new { id = carrera.Id }, new ApiResponse<CarreraDto>(carrera));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateCarreraDto updateCarreraDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var carrera = await _carreraService.UpdateCarreraAsync(updateCarreraDto);
            if (carrera == null)
            {
                return NotFound();
            }
            return Ok(new ApiResponse<CarreraDto>(carrera));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _carreraService.DeleteCarreraAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
