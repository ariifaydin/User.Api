using Microsoft.Extensions.Primitives;
using User.Api.Constants;
using User.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

DatabaseConstant.MSSQL_CONNECTION_STRING = builder.Configuration.GetConnectionString("MSSqlString");
Extension.AddDependencyInjection(builder.Services);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
