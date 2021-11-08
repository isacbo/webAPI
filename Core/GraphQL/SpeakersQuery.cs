using Core.Infrastructure;
using HotChocolate;
using System.Linq;

namespace Contracts.V1.GraphQL
{
	public class Query
    {
        public IQueryable<Core.Models.Speaker> GetSpeakers([Service] ApplicationDbContext context) =>
            context.Speakers;
    }
}
