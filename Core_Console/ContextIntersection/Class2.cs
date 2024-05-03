using Core_Lib.Models;
using Core_Lib.Queries;

namespace Core_Console.ContextIntersection2;

public class AddSomeOrdersCommandHandler(List<Order> orders)
{
    public OrderModel GetSomeOrdersHandle(GetSomeOrdersQuery some)
    {
        var model = orders[some.Count].ToModel();
        return model;
    }
}

public class GetSomeOrdersQueryHandler(List<Order> orders) : IUse<GetSomeOrdersQuery>
{
    public OrderModel GetSomeOrdersHandle(GetSomeOrdersQuery some)
    {
        return orders[some.Count].ToModel();
    }
}

public class RegularClass
{
    public OrderModel GetSomeOrdersHandle(GetSomeOrdersQuery some, List<Order> orders)
    {
        var model = orders[some.Count].ToModel();
        return model;
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