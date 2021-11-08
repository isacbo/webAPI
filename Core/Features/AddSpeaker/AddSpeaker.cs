using Contracts.V1.GraphQL;
using Core.Infrastructure;
using HotChocolate;
using MediatR;
using System.Threading.Tasks;

namespace Core.Features.AddSpeaker
{
	public class Mutation
	{
		

		

		public async Task<AddSpeakerCommandResult> AddSpeakerAsync(AddSpeakerInput input, [Service] ISender sender )
		{
			var result = await sender.Send(new AddSpeakerCommand
			{
				Name = input.Name,
				Bio = input.Bio,
				WebSite = input.WebSite
			});

			return result.Result;
		}
	}
}