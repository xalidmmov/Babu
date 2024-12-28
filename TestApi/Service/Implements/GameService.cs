using AutoMapper;
using TestApi.DAL;
using TestApi.DTOs.Game;
using TestApi.DTOs.Word;
using TestApi.Entities;
using TestApi.Service.Abstracts;

namespace TestApi.Service.Implements
{
    public class GameService(BabuDbContext _context,IMapper _mapper) : IGameService
    {
        async Task<Guid> IGameService.CreateAsync(GameCreateDto dto)
        {
            var game = _mapper.Map<Game>(dto);
            await _context.Games.AddAsync(game);
            await _context.SaveChangesAsync();
            return game.Id;
           
        }

        Task IGameService.End(Guid id)
        {
            throw new NotImplementedException();
        }

        Task IGameService.Fail(Guid id)
        {
            throw new NotImplementedException();
        }

        Task IGameService.RandomWords()
        {
            throw new NotImplementedException();
        }

        Task IGameService.Skip(Guid id)
        {
            throw new NotImplementedException();
        }

        async Task<WordsForGameDto> IGameService.StartAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task IGameService.Succsess(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
