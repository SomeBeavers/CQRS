namespace JetBrains.Annotations.RedundantAttribute;

public class RedundantAttribute
{
    [Query]
    public class RedundantAttributeQueryQuery1
    {
    }
    [Command]
    public class RedundantAttributeCommandCommand1
    {
    }
    [QueryHandler]
    public class RedundantAttributeQueryHandlerQueryHandler1
    {
        public void Test()
        {
            new RedundantAttributeCommandCommand1();
        }
    }

    [CommandHandler]
    public class RedundantAttributeCommandHandlerCommandHandler1
    {
        public void Test()
        {
        }
    }
}