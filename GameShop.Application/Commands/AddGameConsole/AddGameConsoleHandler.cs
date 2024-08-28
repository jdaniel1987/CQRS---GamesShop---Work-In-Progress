﻿using CSharpFunctionalExtensions;
using GameShop.Application.Extensions;
using GameShop.Domain.Repositories;
using MediatR;

namespace GameShop.Application.Commands.AddGameConsole;

public class AddGameConsoleHandler(
    IGameConsoleRepository gameConsoleRepository) : IRequestHandler<AddGameConsoleCommand, IResult<AddGameConsoleResponse>>
{
    private readonly IGameConsoleRepository _gameConsoleRepository = gameConsoleRepository;

    public async Task<IResult<AddGameConsoleResponse>> Handle(AddGameConsoleCommand request, CancellationToken cancellationToken)
    {
        var gameConsole = request.ToDomain();
        await _gameConsoleRepository.AddGameConsole(gameConsole, cancellationToken);

        return Result.Success(gameConsole.ToAddGameConsoleResponse());
    }
}
