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
            Word word = new Word
            {
                LangCode = dto.LangCode,
                Text = dto.Text,
                BannedWords = dto.BannedWords.Select(x=> new BannedWord
                {
                    Text=x
                }).ToList(),

            };
            await _context.Set<Word>().AddAsync(word);
            await _context.SaveChangesAsync();
            return word.Id;
        }

        

        Task<bool> IWordService.DeleteAsync(WordDeleteDto dto)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<WordGetDto>> IWordService.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<bool> IWordService.UpdateAsync(WordUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
