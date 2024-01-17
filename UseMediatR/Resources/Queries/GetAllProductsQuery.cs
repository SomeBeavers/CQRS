using MediatR;
using UseMediatR.Models;

namespace UseMediatR.Resources.Queries;
public class GetAllProductsQuery : IRequest<IEnumerable<Product>>
{
}