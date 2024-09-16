using GameStore.Data;
using GameStore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.EndPoints
{
    public static class GenresEndpoints
    {
        public static RouteGroupBuilder MapGenresEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("genres");

            group.MapGet("/", async (GameStoreContext dbContext) =>

                 await dbContext.Genres
                                .Select(genres => genres.ToDto())
                                .AsNoTracking()
                                .ToListAsync());

            return group;
        }
    }
}
