namespace Core_Console.ContextIntersection._3;

public class MyCommand
{
    public void MyCommandMethod()
    {
    }
}

public class RegularClass
{
    public void MyQueryMethod()
    {
        Test();
    }

    private void Test()
    {
        Test2();
    }

    private void Test2()
    {
        throw new NotImplementedException();
    }
}

public class UseCommandAndQueryClass
{
    public void UseCommandAndQueryMethod(RegularClass rc)
    {
        rc.MyQueryMethod();
    }
}

public class CommandUsingBothCommand
{
    public void UseCommandAndQueryHandlerMethod(UseCommandAndQueryClass parameter)
    {
        parameter.UseCommandAndQueryMethod(null);
    }
}

public class MyClassQuery
{
    void Test(RegularClass bothCommand)
    {
        bothCommand.MyQueryMethod();
    }
}