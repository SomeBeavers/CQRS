using JetBrains.Annotations;

namespace Core_Console.Interfaces11;

[Query]
public interface ITestCommand
{
    public void Test();
}

public interface ITestQuery
{
	public void TestQueryMethod();
}


public class TestQuery : ITestCommand
{
	public void Test()
    {
        Test3();
        //new Test2().Test();
    }

    private void Test3()
    {
        throw new NotImplementedException();
    }
}
public class Test2 
{
    public void Test()
    {
		throw new NotImplementedException();
    }
}