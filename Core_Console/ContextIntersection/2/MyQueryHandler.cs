namespace Core_Console.ContextIntersection;

public class MyQueryHandler
{
    public void Test()
    {
        new TestClass1().Test();
        Test2();
    }

    private void Test2()
    {
        throw new NotImplementedException();
    }
}

public class TestClass1
{
    public void Test()
    {
        throw new NotImplementedException();
    }
}