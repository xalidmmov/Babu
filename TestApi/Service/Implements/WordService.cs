using TestApi.DAL;
using TestApi.DTOs.Word;
using TestApi.Entities;
using TestApi.Service.Abstracts;

namespace TestApi.Service.Implements
{
    public class WordService(BabuDbContext _context) : IWordService
    {
        public async  Task<int> CreateAsync(WordCreateDto dto)
        {
            Word word = new Word();
            await _context.Set<Word>().AddAsync(word);
            return word.Id;
        }
    }
}
