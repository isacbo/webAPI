using Contracts.V1;
using FluentValidation;

namespace Core.Features.GetLocation
{
	public class GetLocationQueryValidator : AbstractValidator<GetLocationQuery>
	{
		public GetLocationQueryValidator()
		{
			RuleFor(m => m.Uid).NotEmpty().WithMessage(x=>string.Format(Resource.Validation_Error, "PropertyName: '{PropertyName}' Value: '{PropertyValue}'"));
		}
	}
}
