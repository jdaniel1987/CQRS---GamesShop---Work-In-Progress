﻿namespace GameShop.Application.Queries.GetGamesForConsole;

public record GetGamesForConsoleResponse(IReadOnlyCollection<GetGamesForConsoleResponseItem> Games);
