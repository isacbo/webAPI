using Common;
using MediatR;

namespace Contracts.V1.GraphQL
{
    public class AddSpeakerCommand : IRequest<CommandResult<AddSpeakerCommandResult>>
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public string WebSite { get; set; }
    }
}
