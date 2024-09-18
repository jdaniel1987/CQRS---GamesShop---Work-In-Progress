﻿using FluentValidation;

namespace GameShop.Application.Read.Queries.GetGamesForConsole;

public class GetGamesForConsoleQueryValidator : AbstractValidator<GetGamesForConsoleQuery>
{
    public GetGamesForConsoleQueryValidator()
    {
        RuleFor(x => x.GameConsoleId)
            .GreaterThan(0).WithMessage("GameConsoleId must be a positive integer.");
    }
}
