﻿namespace GameShop.Application.Read.Queries.GetGamesForConsole;

public record GetGamesForConsoleQueryResponse(IReadOnlyCollection<GetGamesForConsoleQueryResponseItem> Games);
