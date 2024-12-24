using FluentValidation;
using TestApi.DTOs.Language;

namespace TestApi.Validators.Language
{
    public class LanguageCreateDtoValidator:AbstractValidator<LanguageCreateDto>
    {
        public LanguageCreateDtoValidator()
        {
            RuleFor(x => x.Code).NotEmpty().WithMessage("Code bos ola bilmez").NotNull().WithMessage("Code null ola bilmez").Length(2).WithMessage("Code 2 ye beraber olamlidir");
            RuleFor(x => x.Name).MaximumLength(32).MinimumLength(3);
            RuleFor(x => x.IconUrl).MaximumLength(128).Matches("^http(s)?://([\\w-]+.)+[\\w-]+(/[\\w- ./?%&=])?$").WithMessage("Url link olmalidir");


        }
    }
}
