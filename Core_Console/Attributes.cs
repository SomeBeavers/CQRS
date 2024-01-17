// ReSharper disable CheckNamespace
namespace JetBrains.Annotations;

public class CommandAttribute : Attribute { }

public class QueryAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class CommandHandlerAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class QueryHandlerAttribute : Attribute { }

public class NoCqrsAttribute : Attribute { }