using AutoMapper;
using Common;
using Core.Infrastructure;
using Core.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Contracts.V1.GraphQL
{
	public class AddSpeakerCommandHandler : IRequestHandler<AddSpeakerCommand, CommandResult<AddSpeakerCommandResult>>
	{
		private readonly ApplicationDbContext _context;
		private IMapper _mapper;

		public AddSpeakerCommandHandler(ApplicationDbContext context, IMapper mapper)
		{
			this._context = context;
			this._mapper = mapper;
		}

		public async Task<CommandResult<AddSpeakerCommandResult>> Handle(AddSpeakerCommand command, CancellationToken cancellationToken)
		{
			Speaker speaker = new Core.Models.Speaker
			{
				Name = command.Name,
				Bio = command.Bio,
				WebSite = command.WebSite
			};

			this._context.Speakers.Add(speaker);
			await _context.SaveChangesAsync();


			var contractSpeaker = _mapper.Map<TheSpeaker>(speaker);
			return new CommandResult<AddSpeakerCommandResult>(
			new AddSpeakerCommandResult
			{
				TheSpeaker = contractSpeaker
			}, true);
		}
	}
}
