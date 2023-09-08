namespace Core_Lib.Commands;

public interface ICommandHandler<T> : ICommandHandler
	where T : ICommand
{
	void Handle(T command);
}

public interface ICommandHandler
{
}