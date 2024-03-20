using System.ComponentModel.DataAnnotations;

namespace NHLTopScorers.Api.DTOs;

public record class CreatePlayerDto(
    [Required][StringLength(50)] string name,
    [Range(0, 1500)] int goals,
    [Range(0, 2500)] int assists,
    [Range(0, 3500)] int totalPoints);
