using TestApi.DTOs.Word;

namespace TestApi.Service.Abstracts
{
    public interface IWordService
    {
        Task<int> CreateAsync(WordCreateDto dto);
        public Task<IEnumerable<WordGetDto>> GetAsync();
        public Task<Boolean> DeleteAsync(WordDeleteDto dto);
        public Task<Boolean> UpdateAsync(WordUpdateDto dto);
    }
}
