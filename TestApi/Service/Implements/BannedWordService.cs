using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestApi.DAL;
using TestApi.DTOs.BannedWord;
using TestApi.Entities;
using TestApi.Exceptions.BannedWord;
using TestApi.Service.Abstracts;

namespace TestApi.Service.Implements
{
   
        public class BannedWordService(BabuDbContext _context, IMapper _mapper) : IBannedWordService
        {
        

       
           
            async Task<IEnumerable<BannedWordGetDto>> IBannedWordService.GetAsync()
            {
                var datas = await _context.BannedWords.ToListAsync();
                return _mapper.Map<IEnumerable<BannedWordGetDto>>(datas);
            }

            async Task<bool> IBannedWordService.UpdateAsync(BannedWordupdateDto dto)
            {
                var data = _context.BannedWords.FirstOrDefault(x => x.Text == dto.Text);
                if (data != null)
                {
                    _mapper.Map<BannedWord>(dto);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
        }
}
