namespace JetBrains.Annotations.ContextIntersection;

public class AddPersonCommandHandler
{
    public void AddPersonCommandHandlerMethod()
    {
        new RegularClass().UseGetPersonsQueryHandlerMethod();
    }
}