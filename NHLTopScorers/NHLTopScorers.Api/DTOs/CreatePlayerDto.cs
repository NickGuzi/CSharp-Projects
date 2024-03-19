﻿namespace NHLTopScorers.Api.DTOs;

public record class CreatePlayerDto(
    string name,
    int goals,
    int assists,
    int totalPoints);
