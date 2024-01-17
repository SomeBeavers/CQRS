using Core_Lib.Models;
using Core_Lib.Queries;

namespace Core_Console.ContextIntersection;

public class GetSomeOrdersQueryHandler(List<Order> orders) : IUse<GetSomeOrdersQuery>
{

    public OrderModel GetSomeOrdersHandle(GetSomeOrdersQuery some)
    {
        return orders[some.Count].ToModel();
    }
}

public interface IUse<T>
{
}

public static class ConvertToModelExtensions
{
    public static OrderModel ToModel(this Order order)
    {
        return new OrderModel();
    }
}