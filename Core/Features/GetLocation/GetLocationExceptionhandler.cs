using Contracts.V1;
using MediatR.Pipeline;
using System;

namespace Core.Features.GetLocation
{
	public class GetLocationQueryExceptionHandler : RequestExceptionHandler<GetLocationQuery, Exception>
	{
		protected override void Handle(GetLocationQuery query, Exception exception, RequestExceptionHandlerState<Exception> state)
		{
			state.SetHandled(new Exception("Error"));

		}
	}
}
