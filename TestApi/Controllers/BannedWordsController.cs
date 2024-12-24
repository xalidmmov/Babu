﻿using Microsoft.AspNetCore.Http;
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
            [HttpPost]
            public async Task<IActionResult> Create(BannedWordCreateDto dto)
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
                            StatusCode = bEx.StatusCode,
                            Message = bEx.ErrorMessage
                        });
                    }
                    else
                    {
                        return BadRequest(new
                        {
                            ex.Message,
                        });

                    }
                }
            }
            [HttpDelete]
            public async Task<IActionResult> Delete(BannedWordDeleteDto dto)
            {
                bool result = await _service.DeleteAsync(dto);

                return Ok(result);
            }
            [HttpPut]
            public async Task<IActionResult> Update(BannedWordupdateDto dto)
            {
                var result = await _service.UpdateAsync(dto);
                return Ok(result);
            }

        }
    }

