using Core_Console.DB;
using Microsoft.EntityFrameworkCore;

namespace Core_Console.ContextIntersection;

public class DBQueries(TestContext context)
{
    public async Task<Film> GetFilmById(GetFilmByIdQuery request, CancellationToken cancellationToken)
    {
        return await context.Films.Where(film => film.Id == request.Id).FirstAsync(cancellationToken: cancellationToken);
    }
}