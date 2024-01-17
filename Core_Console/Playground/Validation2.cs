namespace Core_Console.Playground;

public class Validation2
{
    public bool ValidateId(IMinimalModel model)
    {
        return new Validation().ValidateId(model);
    }
}