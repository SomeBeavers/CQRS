using JetBrains.Annotations;

namespace Core_Console.ConflictingAttribute;

/// <summary>
///     [AttributeUsage(AttributeTargets.Method)]
///     public class CommandMethodAttribute : Attribute { }
///     public class CommandAttribute : Attribute { }
///     [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct)]
///     public class CommandHandlerAttribute : Attribute { }
///     [AttributeUsage(AttributeTargets.Method)]
///     public class QueryMethodAttribute : Attribute { }
///     public class QueryAttribute : Attribute { }
///     [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
///     public class QueryHandlerAttribute : Attribute { }
///     public class NoCqrs : Attribute { }
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


    public class MyQuery
    {
        public void Test()
        {
            var a = new ClassWithUnidentifiedName();
            a.Test();
        }
    }
}