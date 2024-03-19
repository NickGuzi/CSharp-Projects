using NHLTopScorers.Api.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string GetPlayerEndpointName = "GetPlayer";

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

//GET /players/1
app.MapGet("players/{id}", (int id) => players.Find(player => player.Id == id))
   .WithName(GetPlayerEndpointName);

//POST /players
app.MapPost("players", (CreatePlayerDto newPlayer) =>
{
    PlayerDto player = new(
        players.Count + 1,
        newPlayer.name,
        newPlayer.goals,
        newPlayer.assists,
        newPlayer.totalPoints);

    players.Add(player);

    return Results.CreatedAtRoute(GetPlayerEndpointName, new {id = player.Id}, player);
});

//PUT /players
app.MapPut("players/{id}", (int id, UpdatePlayerDto updatedPlayer) =>
{
    var index = players.FindIndex(player => player.Id == id);

    players[index] = new PlayerDto(
       id,
       updatedPlayer.name,
       updatedPlayer.goals,
       updatedPlayer.assists,
       updatedPlayer.totalPoints);

    return Results.NoContent();
});

app.Run();
