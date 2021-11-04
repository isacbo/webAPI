using Common;
using Contracts.V1;
using Core.Services;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Features.GetLocation
{
	public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, CommandResult<GetLocationQueryResponse>>
	{
		private readonly ILocationService _locationService;
		public GetLocationQueryHandler(ILocationService locationService)
		{
			_locationService = locationService;
		}

		public async Task<CommandResult<GetLocationQueryResponse>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
		{
			var locationResult = _locationService.Get();
			var result = new CommandResult<GetLocationQueryResponse>(new GetLocationQueryResponse
			{
				Uid = request.Uid,
				Location = locationResult
			}, true);

			return await Task.FromResult(result);
		}
	}
}
