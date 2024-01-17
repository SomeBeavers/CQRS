using JetBrains.Annotations;

namespace Core_Console.Playground;

public class Validation
{
    public bool ValidateId(IMinimalModel model) => model.Id >= 0;
}