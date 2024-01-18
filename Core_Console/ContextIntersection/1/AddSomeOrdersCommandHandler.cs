using Core_Lib.Models;
using Core_Lib.Queries;

namespace Core_Console.ContextIntersection;

public class AddSomeOrdersCommandHandler(List<Order> orders)
{
    public OrderModel GetSomeOrdersHandle(GetSomeOrdersQuery some)
    {
        var model = new GetSomeOrdersQueryHandler(orders).GetSomeOrdersHandle(some);
        return model;
    }
}