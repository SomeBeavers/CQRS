namespace Core_Console;

public interface IMinimalModel
{
    public int Id { get; set; }

    public bool ValidateId() => Id >= 0;
}