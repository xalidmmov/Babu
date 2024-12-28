using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.DTOs.BannedWord;
using TestApi.Exceptions;
using TestApi.Service.Abstracts;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
        public class BannedWordsController(IBannedWordService _service) : ControllerBase
        {
            [HttpGet]
            public async Task<IActionResult> Get()
            {

                return Ok(await _service.GetAsync());
            }
            
           
            [HttpPut]
            public async Task<IActionResult> Update(BannedWordupdateDto dto)
            {
                var result = await _service.UpdateAsync(dto);
                return Ok(result);
            }

        }
    }

