using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.DTOs.Word;
using TestApi.Service.Abstracts;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordsController(IWordService _service) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(WordCreateDto dto) { 
            

            return Ok(await _service.CreateAsync(dto));
        
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateMany(List<WordCreateDto> dto)
        {
            foreach(var item in dto)
            {
                await _service.CreateAsync(item);
            }
            return Ok(dto);



        }
    }
}
