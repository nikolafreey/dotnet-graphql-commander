using System.Linq;
using CommanderGraphQL.Data;
using CommanderGraphQL.Models;
using HotChocolate;

namespace CommanderGraphQL.GraphQL
{
    public class Query
    {
        public IQueryable<Platform> GetPlatform([Service] AppDbContext context)
        {
            return context.Platforms;
        }
    }
}