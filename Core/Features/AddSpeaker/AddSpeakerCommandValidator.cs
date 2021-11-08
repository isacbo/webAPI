using Contracts.V1.GraphQL;
using FluentValidation;

namespace Core.Features.AddSpeaker
{
    public class AddSpeakerCommandValidator : AbstractValidator<AddSpeakerCommand>
    {
        public AddSpeakerCommandValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name should have value");
            RuleFor(p => p.Bio).NotEmpty().WithMessage("Bio should have value");
            RuleFor(p => p.WebSite).NotEmpty().WithMessage("WebSite should have value");
        }
    }
}