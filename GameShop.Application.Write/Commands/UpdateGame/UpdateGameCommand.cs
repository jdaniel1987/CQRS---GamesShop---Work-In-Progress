﻿using CSharpFunctionalExtensions;
using MediatR;

namespace GameShop.Application.Write.Commands.UpdateGame;

public record UpdateGameCommand(
    int Id,
    string Name,
    string Publisher,
    int GameConsoleId,
    double Price) : IRequest<IResult<UpdateGameCommandResponse>>;
