namespace NHLTopScorers.Api.DTOs;

public record class PlayerDto(
    int Id, 
    string name, 
    int goals,
    int assists,
    int totalPoints);
