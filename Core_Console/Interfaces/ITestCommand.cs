namespace Core_Console.Interfaces;

public interface ITestCommand
{
    public void TestCommandMethod();
}

public class TestCommand : ITestCommand
{
    public void TestCommandMethod()
    {
        throw new NotImplementedException();
    }
}

public class TestQuery : ITestCommand
{
    public void TestCommandMethod()
    {
        new TestCommand().TestCommandMethod();

	}
}