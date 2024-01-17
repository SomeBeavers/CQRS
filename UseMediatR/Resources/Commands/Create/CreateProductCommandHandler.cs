using MediatR;
using UseMediatR.Data;
using UseMediatR.Models;

namespace UseMediatR.Resources.Commands.Create;
public class CreateProductCommandHandler(ProductDBContext dbContext) : IRequestHandler<CreateProductCommand, Product>
{
	public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product()
        {
            Name = request.Name,
            Description = request.Description,
            Category = request.Category,
            Price = request.Price,
        };

        dbContext.Products.Add(product);
        await dbContext.SaveChangesAsync(cancellationToken);
        return product;
    }
}
