﻿using CSharpFunctionalExtensions;
using GameShop.Application.Read.Mappers;
using GameShop.Domain.Repositories;
using MediatR;

namespace GameShop.Application.Read.Queries.GetAllGames;

public class GetAllGamesHandler(
    IGameReadRepository gameReadRepository) : IRequestHandler<GetAllGamesQuery, IResult<GetAllGamesQueryResponse>>
{
    private readonly IGameReadRepository _gameReadRepository = gameReadRepository;

    public async Task<IResult<GetAllGamesQueryResponse>> Handle(GetAllGamesQuery query, CancellationToken cancellationToken)
    {
        var games = await _gameReadRepository.GetAllGames(cancellationToken);

        return Result.Success(games.ToGetAllGamesQueryResponse());
    }
}
