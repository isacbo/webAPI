using Core.Infrastructure;
using Core.Models;
using HotChocolate;
using System.Linq;

namespace Contracts.V1.GraphQL
{
	public class Query
    {
        public IQueryable<Speaker> GetSpeakers([Service] ApplicationDbContext context) =>
            context.Speakers;
    }
}
