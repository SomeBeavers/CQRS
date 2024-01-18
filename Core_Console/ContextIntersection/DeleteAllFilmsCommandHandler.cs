using Core_Console.DB;
using JetBrains.Annotations;
using MediatR;

namespace Core_Console.ContextIntersection;


public class DeleteAllFilmsCommandHandler(TestContext dbContext, DerivedGetAllFilmsQueryHandler handler) : IRequestHandler<DeleteAllFilmsCommand>, IMyQuery
{
    private readonly DBQueries dbQueries = new DBQueries(dbContext);
    public Task<Unit> Handle(DeleteAllFilmsCommand request, CancellationToken cancellationToken)
    {
        if (request != null)
        {
           // handler.Handle(new GetAllFilmsQuery() { }, cancellationToken);
        }
        else
        {
            var filmById = dbQueries.GetFilmById(new GetFilmByIdQuery
            {
                Id = 0
            }, cancellationToken);
            (handler).MethodFromInterface();
        }
        
        return null;
    }
}

public interface IMyQuery
{
}


public class MyCommand1 : IMyQuery
{
}