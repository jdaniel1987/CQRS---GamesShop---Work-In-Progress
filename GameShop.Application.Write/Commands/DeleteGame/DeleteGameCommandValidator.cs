﻿using FluentValidation;

namespace GameShop.Application.Write.Commands.DeleteGame;

public class DeleteGameCommandValidator : AbstractValidator<DeleteGameCommand>
{
    public DeleteGameCommandValidator()
    {
        RuleFor(x => x.GameId)
            .GreaterThan(0).WithMessage("GameId must be a positive integer.");
    }
}
