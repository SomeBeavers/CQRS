using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using UseMediatR.Data;
using UseMediatR.Models;
using UseMediatR.Resources.Commands.Create;
using UseMediatR.Resources.Commands.Delete;
using UseMediatR.Resources.Commands.Update;
using UseMediatR.Resources.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProductDBContext>();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("product/get-all", async (IMediator mediator) =>
{
	try
	{
		var command = new GetAllProductsQuery();
		var response = await mediator.Send(command);
		return response is not null ? Results.Ok(response) : Results.NotFound();
	}
	catch (Exception ex)
	{
		return Results.BadRequest(ex.Message);
	}
});

app.MapGet("product/get-by-id", async (IMediator mediator, int id) =>
{
	try
	{
		var command = new GetProductByIdQuery() { Id = id };
		var response = await mediator.Send(command);
		return response is not null ? Results.Ok(response) : Results.NotFound();
	}
	catch (Exception ex)
	{
		return Results.BadRequest(ex.Message);
	}
});

app.MapPost("product/create", async (IMediator mediator, Product product) =>
{
	try
	{
		var command = new CreateProductCommand()
		{
			Name = product.Name,
			Description = product.Description,
			Category = product.Category,
			Price = product.Price,
			Active = product.Active,
		};
		var response = await mediator.Send(command);
		return response is not null ? Results.Ok(response) : Results.NotFound();
	}
	catch (Exception ex)
	{
		return Results.BadRequest(ex.Message);
	}
});


app.MapPut("product/update", async (IMediator mediator, Product product) =>
{
	try
	{
		var command = new UpdateProductCommand()
		{
			Id = product.Id,
			Name = product.Name,
			Description = product.Description,
			Category = product.Category,
			Price = product.Price,
			Active = product.Active,
		};
		var response = await mediator.Send(command);
		return response is not null ? Results.Ok(response) : Results.NotFound();
	}
	catch (Exception ex)
	{
		return Results.BadRequest(ex.Message);
	}
});

app.MapDelete("product/delete", async (IMediator mediator, int id) =>
{
	try
	{
		var command = new DeleteProductCommand() { Id = id };
		var response = await mediator.Send(command);
		return response is not null ? Results.Ok(response) : Results.NotFound();
	}
	catch (Exception ex)
	{
		return Results.BadRequest(ex.Message);
	}
});

app.Run();