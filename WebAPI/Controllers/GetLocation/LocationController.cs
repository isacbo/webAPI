using Contracts.V1;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
	[ApiController]
	[Route("v1/[controller]")]
	[Produces("application/json")]
	public class LocationController : ControllerBase
	{
		private readonly ILogger<LocationController> _logger;
		private readonly IMediator _mediator;

		public LocationController(ILogger<LocationController> logger, IMediator mediator)
		{
			this._logger = logger;
			this._mediator = mediator;
		}

		[HttpGet("{uid}")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetLocationQueryResponse))]
		public async Task<ActionResult<GetLocationQueryResponse>> GetAsync(Guid uid)
		{
			var result = await this._mediator.Send(new GetLocationQuery { Uid = uid});
			return new ActionResult<GetLocationQueryResponse>(result.Result);
		}
	}
}
