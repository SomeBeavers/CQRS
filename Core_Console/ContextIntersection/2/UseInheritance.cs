using static Core_Console.ContextIntersection.Inheritance;

namespace Core_Console.ContextIntersection;

public class UseInheritance
{
    public record MyQuery(IAddCommand<TestClass> AddCommand)
    {
        public void TestCommand()
        {
            //AddCommand.Execute(new TestClass());
        }
    }
}

public class TestClass
{
}

#nullable disable

public class My2Query<T> where T : IOther<TestClass>
{
    public void Test(T t, BaseAddDerivedCommand<TestClass> command)
    {
        //t.Execute(new TestClass());
        //t.Execute();

        //command.Execute(new TestClass());
        //command.Test();

        var list = new List<BaseAddDerivedCommand<TestClass>> { command };
        //list.Where(x => x.Execute());
        NewFunction();

        void NewFunction()
        {
            NewFunction1();
        }

        void NewFunction1()
        {
            list.FirstOrDefault(x => x.Equals(command))?.Execute(new TestClass());
        }
    }
}