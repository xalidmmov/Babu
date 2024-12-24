using AutoMapper;
using TestApi.DTOs.Language;
using TestApi.Entities;

namespace TestApi.Profiles
{
    public class LanguageProfile : Profile
    {
        public LanguageProfile()
        {
            CreateMap<LanguageCreateDto, Language>().ForMember(l=>l.Icon,lcd=>lcd.MapFrom(x=>x.IconUrl));
            CreateMap<Language, LanguageGetDto>();
            CreateMap<LanguageUpdateDto, Language>();
        }
    }
}
