using Common;
using MediatR;
using System;

namespace Contracts.V1
{
	public class GetLocationQuery : IRequest<CommandResult<GetLocationQueryResponse>>
	{
		public Guid Uid { get; set; }
	}
}
