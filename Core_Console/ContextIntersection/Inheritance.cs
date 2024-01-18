using System.Text;

namespace Core_Console.ContextIntersection;

public partial class Inheritance
{
    public partial record BaseAddCommand<T> : IAddCommand<T>
    {
        public virtual void Execute(T command)
        {
            throw new NotImplementedException();
        }
    }

    public record BaseAddDerivedCommand<T> : BaseAddCommand<T>
    {
        protected override bool PrintMembers(StringBuilder builder)
        {
            return base.PrintMembers(builder);
        }

        public override void Execute(T command)
        {
            Test();
            base.Execute(command);
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}

public interface IAddCommand<T>
{
    void Execute(T command);
}

public interface IOther<T> : IAddCommand<T>
{
    void Execute();
}