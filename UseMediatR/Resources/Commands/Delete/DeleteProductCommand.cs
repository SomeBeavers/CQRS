using MediatR;
using UseMediatR.Models;

namespace UseMediatR.Resources.Commands.Delete;
public class DeleteProductCommand : IRequest<Product>
{
    public int Id { get; set; }
}