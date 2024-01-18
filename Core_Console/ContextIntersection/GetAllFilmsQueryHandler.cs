using Core_Console.DB;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Core_Console.ContextIntersection;

public class GetAllFilmsQueryHandler(TestContext context) : IRequestHandler<GetAllFilmsQuery, IEnumerable<Film>>, IFilmsQueryHandler
{
    public async Task<IEnumerable<Film>> Handle(GetAllFilmsQuery request, CancellationToken cancellationToken) =>
        await context.Films.ToListAsync(cancellationToken: cancellationToken);

    public string MethodFromInterface()
    {
        return "Jane Doe";
    }
}