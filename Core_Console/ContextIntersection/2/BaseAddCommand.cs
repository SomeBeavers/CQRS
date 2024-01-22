namespace Core_Console.ContextIntersection;

public partial class Inheritance
{
    public partial record BaseAddCommand<T>
    {
        public bool Verify(T t)
        {
            return t != null;
        }
    }
}