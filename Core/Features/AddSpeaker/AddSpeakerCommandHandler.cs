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
        private readonly IApplicationDbContext _context;

        public AddSpeakerCommandHandler(IApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<CommandResult<AddSpeakerCommandResult>> Handle(AddSpeakerCommand command, CancellationToken cancellationToken)
        {
            var speaker = new Speaker
            {
                Name = command.Name,
                Bio = command.Bio,
                WebSite = command.WebSite
            };

            this._context.Speakers.Add(speaker);
            await ((ApplicationDbContext) this._context).SaveChangesAsync();
            
            return new CommandResult<AddSpeakerCommandResult>(
                new AddSpeakerCommandResult 
                { 
                    Name = speaker.Name,
                    Bio = speaker.Bio,
                    WebSite = speaker.WebSite                
                }, true);
        }
    }
}
