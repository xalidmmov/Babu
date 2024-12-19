using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.DTOs.Language;
using TestApi.Service.Abstracts;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController(ILanguageService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _service.GetAllAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Create(LanguageCreateDto dto)
        {
            await _service.CreateAsync(dto);
            return Ok();    
        }
        [HttpPut]
        public async Task<IActionResult> Update(string code, LanguageUpdateDto dto)
        {
            var result = await _service.UpdateAsync(code, dto);
            if (result)
            {
                return Ok(); 
            }
            return BadRequest(); 
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string code)
        {
            var result = await _service.DeleteAsync(code);
            if (result)
            {
                return Ok(); 
            }
            return BadRequest(); 
        }
    }
}
