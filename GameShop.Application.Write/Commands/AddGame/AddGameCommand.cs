﻿using CSharpFunctionalExtensions;
using GameShop.API.Write.Contracts.Responses;
using MediatR;

namespace GameShop.Application.Write.Commands.AddGame;

public record AddGameCommand(
    string Name,
    string Publisher,
    int GameConsoleId,
    double Price) : IRequest<IResult<AddGameResponse>>;
