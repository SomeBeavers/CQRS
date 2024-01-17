using MediatR;
using UseMediatR.Data;
using UseMediatR.Models;

namespace UseMediatR.Resources.Commands.Delete;
public class DeleteProductCommandHandler(ProductDBContext dbContext) : IRequestHandler<DeleteProductCommand, Product>
{
	public async Task<Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var product = dbContext.Products.FirstOrDefault(p => p.Id == request.Id);

        if (product is null)
            return default;

        dbContext.Remove(product);
        await dbContext.SaveChangesAsync(cancellationToken);
        return product;
    }
}