using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using TestApi.DTOs.Language;
using TestApi.Entities;
using TestApi.Exceptions;
using TestApi.Service.Abstracts;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController(ILanguageService _service,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _service.GetAllAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Create(LanguageCreateDto dto)
        {
            try
            {
                await _service.CreateAsync(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                if (ex is IBaseException bEx)
                {
                    return StatusCode(bEx.StatusCode, new
                    {

                        Message = bEx.ErrrorMessage
                    });
                }
                else
                {
                    return BadRequest(new
                    {
                        Message= ex.Message
                    });
                }
                

            }
            //var data= _mapper.Map<Language>(dto);  
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
