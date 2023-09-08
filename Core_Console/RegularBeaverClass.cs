using Core_Lib.Commands;
using Framework_Console;
using JetBrains.Annotations;

namespace Core_Console;

public class RegularBeaverClass
{

	public void RegularBeaverMethod(Beaver beaver)
	{
		new BeaversQuery().GetBeaver("Bob");
		NewFunction();
		//SharedCommand.AddBeaverCommand(beaver);
		//SharedQuery.GetBeaver(beaver.Name);
		void NewFunction()
		{
			new BeaverCommandHandler().Handle(new RemoveBeaverCommand { BeaverId = beaver.Id });
		}
	}
}