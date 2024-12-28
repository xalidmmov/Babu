using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using TestApi.DTOs.Game;
using TestApi.Service.Abstracts;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController(IGameService _service, IMemoryCache _cache) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(GameCreateDto dto)
        {
            return Ok(await _service.CreateAsync(dto));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> Get(string key)
        {
            return Ok(_cache.Get(key));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> Set(string key, string value)
        {

            return Ok(_cache.Set<string>(key, value, DateTime.Now.AddSeconds(20)));
        }

        //[HttpPut("[action]")]
        //public async Task<IActionResult> Start(Guid id)
        //{
        //    return Ok(await _service.Start(id));
        //}
    }
}