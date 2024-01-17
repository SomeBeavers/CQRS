using MediatR;
using Microsoft.EntityFrameworkCore;
using UseMediatR.Data;
using UseMediatR.Models;

namespace UseMediatR.Resources.Queries;
public class GetAllProductsQueryHandler(ProductDBContext context)
    : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
{
    public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken) =>
        await context.Products.ToListAsync(cancellationToken: cancellationToken);
}