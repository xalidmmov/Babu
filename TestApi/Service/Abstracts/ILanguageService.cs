using TestApi.DTOs.Language;

namespace TestApi.Service.Abstracts
{
    public interface ILanguageService
    {
        Task CreateAsync(LanguageCreateDto dto);
        Task<IEnumerable<LanguageGetDto>> GetAllAsync();
        Task<bool> DeleteAsync(string code); 
        Task<bool> UpdateAsync(string code, LanguageUpdateDto dto);
    }
}
