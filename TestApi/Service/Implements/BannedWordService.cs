using AutoMapper;
using TestApi.DAL;
using TestApi.DTOs.BannedWord;
using TestApi.Entities;
using TestApi.Exceptions.BannedWord;
using TestApi.Service.Abstracts;

namespace TestApi.Service.Implements
{
   
        public class BannedWordService(BabuDbContext _context, IMapper _mapper) : IBannedWordService
        {
        public Task<bool> UpdateAsync(BannedWordupdateDto dto)
        {
            throw new NotImplementedException();
        }

        async Task IBannedWordService.CreateAsync(BannedWordCreateDto dto)
            {
                if (await _context.BannedWords.AnyAsync(x => x.Text == dto.Text))
                    throw new BannedWordExistException();
                await _context.BannedWords.AddAsync(_mapper.Map<BannedWord>(dto));
                await _context.SaveChangesAsync();
            }

            async Task<bool> IBannedWordService.DeleteAsync(BannedWordDeleteDto dto)
            {
                var data = await _context.BannedWords.FirstOrDefaultAsync(x => x.Text == dto.Text);
                if (data != null)
                {
                    _context.BannedWords.Remove(data);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }

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
