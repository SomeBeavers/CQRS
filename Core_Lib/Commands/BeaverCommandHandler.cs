using Framework_Console;

namespace Core_Lib.Commands;

public class BeaverCommandHandler: ICommandHandler<RemoveBeaverCommand>
{
	public void Handle(RemoveBeaverCommand command)
	{
		BeaversRepo.GetBeaver("");
		BeaversRepo.RemoveBeaver(command.BeaverId);


	}
}