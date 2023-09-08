using Core_Lib.Commands;

var beaver = new BeaversQuery().GetBeaver("Bob");
new BeaverCommandHandler().Handle(new RemoveBeaverCommand { BeaverId = beaver.Id });

