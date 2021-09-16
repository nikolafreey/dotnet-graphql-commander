using System.Linq;
using CommanderGraphQL.Data;
using CommanderGraphQL.Models;
using HotChocolate;
using HotChocolate.Data;

namespace CommanderGraphQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context)
        {
            return context.Platforms;
        }
    }
}