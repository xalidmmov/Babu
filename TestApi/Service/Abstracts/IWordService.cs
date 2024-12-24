using TestApi.DTOs.Word;

namespace TestApi.Service.Abstracts
{
    public interface IWordService
    {
        Task<int> CreateAsync(WordCreateDto dto);
    }
}
