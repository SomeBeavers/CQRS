namespace JetBrains.Annotations.ContextIntersection;

public class RegularClass
{
    public void UseGetPersonsQueryHandlerMethod()
    {
        UseGetPersonsQueryHandlerMethod2();
    }

    public void UseGetPersonsQueryHandlerMethod22()
    {
        UseAddPersonCommandHandlerMethod();
    }

    private static void UseGetPersonsQueryHandlerMethod2()
    {
        new GetPersonsQueryHandler().GetPersonsQueryHandlerMethod();
    }

    public void UseAddPersonCommandHandlerMethod()
    {
        new GetPersonsQueryHandler().GetPersonsQueryHandlerMethod();
    }
}

public class RegularClass2
{
    public void UseGetPersonsQueryHandlerMethod()
    {
        new RegularClass().UseGetPersonsQueryHandlerMethod22();
    }
}