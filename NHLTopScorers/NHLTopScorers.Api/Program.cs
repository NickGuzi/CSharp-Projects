using NHLTopScorers.Api.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<PlayerDto> players = [
    new (
        1,
        "Wayne Gretzky",
        894,
        1963,
        2857),
    new (
        2,
        "Jaromir Jagr",
        766,
        1155,
        1921),
    new (
        3,
        "Mark Messier",
        694,
        1193,
        1887) 
];

//GET /players
app.MapGet("players", () => players);

//GET /games/1
app.MapGet("players/{id}", (int id) => players.Find(player => player.Id == id));

app.Run();
