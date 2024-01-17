namespace Core_Console.Playground;

public interface IMinimalModel
{
    public int Id { get; set; }

    public bool ValidateId() => Id >= 0;
}