namespace Core_Console;

public class Validation2
{
    public bool ValidateId(IMinimalModel model)
    {
        return new Validation().ValidateId(model);
    }
}