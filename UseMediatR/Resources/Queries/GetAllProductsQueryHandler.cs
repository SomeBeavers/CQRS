using MediatR;
using Microsoft.EntityFrameworkCore;
using UseMediatR.Data;
using UseMediatR.Models;

namespace UseMediatR.Resources.Queries;
public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
{
    private readonly ProductDBContext _context;
    public GetAllProductsQueryHandler(ProductDBContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken) =>
        await _context.Products.ToListAsync();
}