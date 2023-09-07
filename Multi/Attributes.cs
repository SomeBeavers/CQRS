// ReSharper disable CheckNamespace
namespace JetBrains.Annotations;

[AttributeUsage(AttributeTargets.Method)]
public class CommandMethodAttribute : Attribute { }

public class CommandAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct)]
public class CommandHandlerAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Method)]
public class QueryMethodAttribute : Attribute { }

public class QueryAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class QueryHandlerAttribute : Attribute { }

public class NoCqrs: Attribute { }
