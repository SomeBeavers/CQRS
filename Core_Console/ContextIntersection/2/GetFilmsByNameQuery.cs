namespace Core_Console.ContextIntersection;

public interface IFilm
{
    string Name { get; set; }
    int Id { get; set; }
    void MethodFromInterfaceDefault2();
}

public interface IGetFilmsByQuery : IFilm
{
    void MethodFromInterfaceDefault()
    {
        MethodFromInterfaceDefault2();
    }
}

public class GetFilmsByNameQuery : IGetFilmsByQuery
{
    public string? Description { get; set; }
    public string Name { get; set; }

    public int Id { get; set; }

    public void MethodFromInterfaceDefault2()
    {
        Console.WriteLine("Test");
        LocalFunc();

        void LocalFunc()
        {
            Console.WriteLine("Test");
        }
    }
}