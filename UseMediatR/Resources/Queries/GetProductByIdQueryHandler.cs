using MediatR;
using Microsoft.EntityFrameworkCore;
using UseMediatR.Data;
using UseMediatR.Models;

namespace UseMediatR.Resources.Queries;

public class GetProductByIdQueryHandler(ProductDBContext context) : IRequestHandler<GetProductByIdQuery, Product>
{
    public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken) =>
        await context.Products.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
}
