namespace JetBrains.Annotations.ContextIntersection;

public class AddPersonCommandHandler
{
    public void AddPersonCommandHandlerMethod()
    {
        new RegularClass().UseGetPersonsQueryHandlerMethod();
    }
}
public class AddPerson2CommandHandler
{
    public void AddPerson2CommandHandlerMethod(RegularClass regularClass)
    {
        regularClass.UseGetPersonsQueryHandlerMethod();
        regularClass.UseGetPersonsQueryHandlerMethod22();
    }
}