using Core_Lib.Models;
using Core_Lib.Queries;
using JetBrains.Annotations;

namespace Core_Console.ContextIntersection;

public class GetSomeOrdersQueryHandler(List<Order> orders) : IQueryHandler<GetSomeOrdersQuery>
{
    public OrderModel result;

    public OrderModel GetSomeOrdersHandle(GetSomeOrdersQuery some)
    {
        new AddSomeOrdersCommandHandler(orders).GetSomeOrdersHandle(some);
        return orders[some.Count].ToModel();
    }

    public void Handle(GetSomeOrdersQuery some)
    {
        result = GetSomeOrdersHandle(some);
    }
}


public interface IQueryHandler<T>
{
    public void Handle(GetSomeOrdersQuery some);
}