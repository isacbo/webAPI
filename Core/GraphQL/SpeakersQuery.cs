using Core.Infrastructure;
using Core.Models;
using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.V1.GraphQL
{
    public class Query
    {
        public IQueryable<Speaker> GetSpeakers([Service] ApplicationDbContext context) =>
            context.Speakers;
    }

    public class Mutation 
    {
        public async Task<AddSpeakerPayload> AddSpeakerAsync(AddSpeakerInput input, [Service] ApplicationDbContext context)
        {
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
