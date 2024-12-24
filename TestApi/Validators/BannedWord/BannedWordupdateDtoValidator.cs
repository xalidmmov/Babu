using FluentValidation;
using TestApi.DTOs.BannedWord;

namespace TestApi.Validators.BannedWord
{
    public class BannedWordupdateDtoValidator : AbstractValidator<BannedWordupdateDto>
    {
        public BannedWordupdateDtoValidator()
        {
            RuleFor(x => x.Text)
            .NotEmpty()
            .WithMessage("Text bos olmamalidir")
            .NotNull()
            .WithMessage("Text null olmamalidir")
            .MaximumLength(32);
            RuleFor(x => x.WordId)
                .NotEmpty()
                .WithMessage("WordId bos olmamalidir")
                .NotNull()
                .WithMessage("WordId null olmmalidir");
        }
    }
}
