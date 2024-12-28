using TestApi.DTOs.Game;
using TestApi.DTOs.Word;
using TestApi.Entities;

namespace TestApi.Service.Abstracts
{
    public interface IGameService
    {
        Task<Guid> CreateAsync(GameCreateDto dto);
        public Task<WordsForGameDto> StartAsync(Guid id);
        Task Fail(Guid id);
        Task End(Guid id);
        Task Skip(Guid id);
        Task RandomWords();
        Task Succsess(Guid id);
    }
}
