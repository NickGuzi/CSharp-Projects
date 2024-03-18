namespace NHLTopScorers.Api.DTOs;

public record class PlayerDto(
    int Id, 
    string Name, 
    int goals,
    int assists,
    int totalPoints);
