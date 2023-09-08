namespace Core_Lib.Commands;

public class RemoveBeaverCommand : ICommand
{
    public Guid Id { get; } = Guid.NewGuid();
    public int BeaverId { get; set; }
}