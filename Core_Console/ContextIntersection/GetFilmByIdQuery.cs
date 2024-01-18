using Core_Console.DB;
using MediatR;

namespace Core_Console.ContextIntersection;

public class GetFilmByIdQueryBase
{
    public override bool Equals(object? obj)
    {
        Console.WriteLine("");
        Test();
        return base.Equals(obj);
    }

    private void Test()
    {
        new MyClass().Test();
        throw new NotImplementedException();
    }
}

public class MyClass
{
    public void Test()
    {
        Test2();
    }

    private void Test2()
    {
        throw new NotImplementedException();
    }
}

public class GetFilmByIdQuery: GetFilmByIdQueryBase, IRequest<Film>
{

    public int Id { get; set; }
    public override bool Equals(object? obj)
    {
        Console.WriteLine("");
        return base.Equals(obj);
    }
}