namespace NHLTopScorers.Api.DTOs;

public record class UpdatePlayerDto(
    string name,
    int goals,
    int assists,
    int totalPoints);
