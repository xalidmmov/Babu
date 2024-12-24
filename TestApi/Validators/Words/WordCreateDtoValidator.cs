using FluentValidation;
using TestApi.DTOs.Word;

namespace TestApi.Validators.Words
{
    public class WordCreateDtoValidator:AbstractValidator<WordCreateDto>
    {
        public WordCreateDtoValidator() { 
        RuleForEach(x=>x.BannedWords).NotNull().MinimumLength(2);
            RuleFor(x => x.BannedWords).NotNull().Must(x => x.Count == 6);
        
        }
    }
}
