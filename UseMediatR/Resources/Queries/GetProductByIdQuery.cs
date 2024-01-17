using MediatR;
using UseMediatR.Models;

namespace UseMediatR.Resources.Queries;
public class GetProductByIdQuery : IRequest<Product>
{
    public int Id { get; set; }
}