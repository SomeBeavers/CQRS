using Shared;

namespace ReadModel;

public class BeaverCommand
{
	public void AddBeaverCommand(Beaver beaver)
	{
	}
}
public class BeaverQuery
{
	public Beaver GetBeaver(Beaver? beaver)
	{
		new BeaverCommand().AddBeaverCommand(beaver!);
		return null;
	}
}