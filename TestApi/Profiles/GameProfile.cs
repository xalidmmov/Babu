using AutoMapper;
using TestApi.DTOs.Game;
using TestApi.Entities;

namespace TestApi.Profiles
{
    public class GameProfile:Profile
    {
        public GameProfile()
        {
            CreateMap<GameCreateDto, Game>();
            CreateMap<GameUpdateDto, Game>();

        }
    }
}
