using NHLTopScorers.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPlayersEndpoints();

app.Run();
