using Core.Infrastructure;
using MediatR;
using System.Threading.Tasks;

namespace Contracts.V1.GraphQL
{
    public class Mutation
    {
        private readonly IMediator _mediator;

        public Mutation(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<AddSpeakerPayload> AddSpeakerAsync(AddSpeakerInput input)
        {
            var result = await this._mediator.Send(new AddSpeakerCommand
            {
                Name = input.Name,
                Bio = input.Bio,
                WebSite = input.WebSite
            });

            //return result;
            return new AddSpeakerPayload(new Core.Models.Speaker());
        }
    }
}