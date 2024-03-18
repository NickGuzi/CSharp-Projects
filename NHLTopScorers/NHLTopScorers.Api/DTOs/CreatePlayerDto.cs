namespace NHLTopScorers.Api.DTOs;

public record class CreatePlayerDto(
    string Name,
    int goals,
    int assists,
    int totalPoints);
