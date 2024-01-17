namespace JetBrains.Annotations.UseAttributesFromAnnotations;

public static class Extensions
{
    //[method:NoCqrs]
    public static int GetId(this Model model)
    {
        return model.Id;
    }
}