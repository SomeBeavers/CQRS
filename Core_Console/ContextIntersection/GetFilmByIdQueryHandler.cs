using Core_Console.DB;
using MediatR;

namespace Core_Console.ContextIntersection;

public class GetFilmByIdQueryHandler(TestContext context) : IRequestHandler<GetFilmByIdQuery, Film>
{
    private readonly DBQueries dbQueries = new DBQueries(context);

    public async Task<Film> Handle(GetFilmByIdQuery request, CancellationToken cancellationToken)
    {
        return await dbQueries.GetFilmById(request, cancellationToken);
    }
}