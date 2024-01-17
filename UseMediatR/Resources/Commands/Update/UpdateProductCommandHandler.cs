using MediatR;
using UseMediatR.Data;
using UseMediatR.Models;

namespace UseMediatR.Resources.Commands.Update
{
    public class UpdateProductCommandHandler(ProductDBContext dbContext)
	    : IRequestHandler<UpdateProductCommand, Product>
    {
	    public async Task<Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = dbContext.Products.FirstOrDefault(p => p.Id == request.Id);

            if (product is null)
                return default;

            product.Name = request.Name;
            product.Description = request.Description;
            product.Category = request.Category;
            product.Price = request.Price;

            await dbContext.SaveChangesAsync(cancellationToken);
            return product;
        }
    }
}