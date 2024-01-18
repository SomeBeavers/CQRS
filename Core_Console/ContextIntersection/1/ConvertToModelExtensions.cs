using Core_Lib.Models;

namespace Core_Console.ContextIntersection;

public static class ConvertToModelExtensions
{
    public static OrderModel ToModel(this Order order)
    {
        return new OrderModel();
    }
}