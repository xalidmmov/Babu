using AutoMapper;
using TestApi.DTOs.BannedWord;
using TestApi.Entities;

namespace TestApi.Profiles
{
    public class BannedWordProfile:Profile
    {
        public BannedWordProfile()
        {
            CreateMap<BannedWordCreateDto, BannedWord>();
            CreateMap<BannedWord, BannedWordGetDto>();
            CreateMap<BannedWordupdateDto, BannedWord>();
        }
    }
}
