﻿namespace GameShop.Application.Queries.GetGamesByName;

public record GetGamesByNameQueryResponse(IReadOnlyCollection<GetGamesByNameQueryResponseItem> Games);
