using NHLTopScorers.Api.DTOs;

namespace NHLTopScorers.Api.Endpoints;

public static class PlayersEndpoints
{
    const string GetPlayerEndpointName = "GetPlayer";

    private static readonly List<PlayerDto> players = [
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

    public static RouteGroupBuilder MapPlayersEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("players");

        //GET /players
        group.MapGet("/", () => players);

        //GET /players/1
        group.MapGet("/{id}", (int id) =>
        {
            PlayerDto? player = players.Find(player => player.Id == id);

            return player is null ? Results.NotFound() : Results.Ok(player);
        })
           .WithName(GetPlayerEndpointName);


        //POST /players
        group.MapPost("/", (CreatePlayerDto newPlayer) =>
        {
            PlayerDto player = new(
                players.Count + 1,
                newPlayer.name,
                newPlayer.goals,
                newPlayer.assists,
                newPlayer.totalPoints);

            players.Add(player);

            return Results.CreatedAtRoute(GetPlayerEndpointName, new { id = player.Id }, player);
        });

        //PUT /players
        group.MapPut("/{id}", (int id, UpdatePlayerDto updatedPlayer) =>
        {
            var index = players.FindIndex(player => player.Id == id);

            if (index == -1)
            {
                return Results.NotFound();
            }

            players[index] = new PlayerDto(
               id,
               updatedPlayer.name,
               updatedPlayer.goals,
               updatedPlayer.assists,
               updatedPlayer.totalPoints);

            return Results.NoContent();
        });

        //DELETE /players
        group.MapDelete("/{id}", (int id) =>
        {
            players.RemoveAll(game => game.Id == id);

            return Results.NoContent();
        });

        return group;
    }
}
