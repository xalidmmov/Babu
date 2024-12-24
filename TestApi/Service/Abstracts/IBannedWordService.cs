using TestApi.DTOs.BannedWord;

namespace TestApi.Service.Abstracts
{
        public interface IBannedWordService
        {
            public Task<IEnumerable<BannedWordGetDto>> GetAsync();
            public Task CreateAsync(BannedWordCreateDto dto);
            public Task<Boolean> DeleteAsync(BannedWordDeleteDto dto);

            public Task<Boolean> UpdateAsync(BannedWordupdateDto dto);
        }
}
