using JetBrains.Annotations;
namespace JetBrains.Annotations.UseAttributesFromAnnotations;
/// <summary>
/// // ReSharper disable CheckNamespace
/// namespace JetBrains.Annotations;
/// 
/// public class CommandAttribute : Attribute { }  -   ✅
/// 
/// public class QueryAttribute : Attribute { }  -   ✅
/// 
/// [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
/// public class CommandHandlerAttribute : Attribute { }  -   ✅
/// 
/// [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
/// public class QueryHandlerAttribute : Attribute { }  -   ✅
/// 
/// public class NoCqrsAttribute: Attribute { }  -   ✅
/// </summary>

public class UseAttributes1
{
    
}

[Command]
public record CommandRecord
{
    public void Test(QueryInterfaceImplementation parameter)
    {
        var type = parameter.GetType();
        parameter.Test();
    }
}

[CommandHandlerAttribute]
public class AddRecordCommandHandler(Model model)
{
    public void Handle()
    {
        var id = model.GetId();
    }
}

[QueryHandler]
public class GetQueryHandler(Model model)
{
    public void Handle()
    {
        var id = model.GetId();
    }
}

public class Model
{
    public int Id { get; set; }
}

[Query]
public interface IQueryInterfaceQuery
{
}

public interface IQueryInterface2: IQueryInterfaceQuery
{
}

public class QueryInterfaceImplementation : IQueryInterfaceQuery
{
    public void Test()
    {
    }
}