using JetBrains.Annotations;

namespace Core_Console.ConflictingAttribute;

/// <summary>
/// // ReSharper disable CheckNamespace
/// namespace JetBrains.Annotations;
/// 
/// public class CommandAttribute : Attribute { }
/// 
/// public class QueryAttribute : Attribute { }
/// 
/// [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
/// public class CommandHandlerAttribute : Attribute { }
/// 
/// [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
/// public class QueryHandlerAttribute : Attribute { }
/// 
/// public class NoCqrsAttribute: Attribute { }
/// </summary>
public class ConflictingAttribute1
{
    public class ClassWithUnidentifiedName
    {
        public void Test()
        {
            throw new NotImplementedException();
        }
    }

    [CommandHandler]
    public class MyQuery
    {
        public void Test()
        {
            var a = new ClassWithUnidentifiedName();
            a.Test();
        }
    }
}