using Core_Console.DB;
using MediatR;

namespace Core_Console.ContextIntersection;

public class DeleteAllFilmsCommandHandler(TestContext dbContext, GetAllFilmsQueryHandler handler) : IRequestHandler<DeleteAllFilmsCommand>
{
    public Task<Unit> Handle(DeleteAllFilmsCommand request, CancellationToken cancellationToken)
    {
        if (request != null)
        {
           // handler.Handle(new GetAllFilmsQuery() { }, cancellationToken);
        }
        else
        {
            ((IFilmsQueryHandler)handler).MethodFromInterface();
        }
        
        return null;
    }
}