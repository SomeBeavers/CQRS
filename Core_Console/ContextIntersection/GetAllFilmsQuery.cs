using Core_Console.DB;
using MediatR;

namespace Core_Console.ContextIntersection;

public class GetAllFilmsQuery : IRequest<IEnumerable<Film>>
{
}