using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestApi.DAL;                                                                                                   
using TestApi.DTOs.Language;
using TestApi.Entities;
using TestApi.Exceptions.Language;
using TestApi.Service.Abstracts;

namespace TestApi.Service.Implements
{
    public class LanguageService(BabuDbContext _context,IMapper _mapper) : ILanguageService
    {
        public async Task CreateAsync(LanguageCreateDto dto)
        {
            //    await _context.Languages.AddAsync(new Entities.Language
            //    {
            //        Name = dto.Name,
            //        Code = dto.Code,
            //        Icon = dto.IconUrl

            //    });
            if(await _context.Languages.AnyAsync(x => x.Code == dto.Code)){
                throw new LanguageExistException();
            }
            await _context.Languages.AddAsync(_mapper.Map<Language>(dto));
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<LanguageGetDto>> GetAllAsync()
        {
            //return await _context.Languages.Select(x=> new LanguageGetDto
            //{
            //    Name = x.Name,
            //    Code = x.Code,
            //    Icon = x.Icon

            //}).ToListAsync();
            var datas=await _context.Languages.ToListAsync();
            return _mapper.Map<IEnumerable<LanguageGetDto>>(datas);
        }
        public async Task<bool> DeleteAsync(string code)
        {
            var result = await _context.Languages.FirstOrDefaultAsync(x => x.Code == code);
            if (result == null)
            {
                return false; 
            }
            _context.Languages.Remove(result);
            await _context.SaveChangesAsync();
            return true; 
        }
        public async Task<bool> UpdateAsync(string code, LanguageUpdateDto dto)
        {
            var result = await _context.Languages.FirstOrDefaultAsync(x => x.Code == code);
            if (result == null)
            {
                return false;
            }

            result.Name = dto.Name;
            result.Icon = dto.Icon;

            _context.Languages.Update(result);
            await _context.SaveChangesAsync();
            return true; 
        }
    }
}
