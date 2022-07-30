using FluentValidation;
using MiddleTemplate.Application.Models;
using NeerCore.Application.Abstractions;

namespace MiddleTemplate.Application.Features.Teas.Commands;

/// <param name="Name">
/// <example>Black tea</example>
/// </param>
/// <param name="Price">
/// <example>19.50</example>
/// </param>
public record TeaCreateCommand(string Name, decimal Price) : ICommand<TeaModel>;

internal class CreateTeaCommandValidator : AbstractValidator<TeaCreateCommand>
{
    public CreateTeaCommandValidator()
    {
        RuleFor(o => o.Name).NotEmpty().Length(2, 64);
        RuleFor(o => o.Price).GreaterThan(0m);
    }
}