//using Microsoft.AspNetCore.Routing;

//namespace Core_Console.Playground;

//public class CargoBookCommand : Command<CargoAggregate, CargoId>
//{
//    public CargoBookCommand(
//        CargoId aggregateId,
//        Route route)
//        : base(aggregateId)
//    {
//        Route = route;
//    }

//    public Route Route { get; }
//}

//public class CargoBookCommandHandler : CommandHandler<CargoAggregate, CargoId, CargoBookCommand>
//{
//    public override Task ExecuteAsync(CargoAggregate aggregate, CargoBookCommand command, CancellationToken cancellationToken)
//    {
//        aggregate.Book(command.Route);
//        return Task.FromResult(0);
//    }
//}

//public class GetCargosQuery : IQuery<IReadOnlyCollection<Cargo>>
//{
//    public GetCargosQuery(
//        params CargoId[] cargoIds)
//        : this((IEnumerable<CargoId>)cargoIds)
//    {

//    }

//    public GetCargosQuery(IEnumerable<CargoId> cargoIds)
//    {

//        CargoIds = cargoIds.ToList();
//    }

//    public IReadOnlyCollection<CargoId> CargoIds { get; }

//    public void Test()
//    {
//        new CargoBookCommandHandler().ExecuteAsync(null, null, default);
//    }
//}