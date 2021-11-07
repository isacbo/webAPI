using Core.Infrastructure;
using Core.Models;
using HotChocolate;
using System.Threading.Tasks;

namespace Contracts.V1.GraphQL
{
	public class Mutation
	{
        public async Task<AddSpeakerPayload> AddSpeakerAsync(AddSpeakerInput input, [Service] ApplicationDbContext context)
        {
            //Form here we potentially can break up into a Mediator pattern with a Pipeline abstraction 
            var speaker = new Speaker
            { 
                Name = input.Name, 
                Bio = input.Bio,
                WebSite = input.WebSite
            };

            context.Speakers.Add(speaker);
            await context.SaveChangesAsync();
            return new AddSpeakerPayload(speaker);
        }
    }
}
