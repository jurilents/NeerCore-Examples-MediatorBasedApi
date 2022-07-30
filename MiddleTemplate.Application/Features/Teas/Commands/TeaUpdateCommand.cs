using System.Text.Json.Serialization;
using FluentValidation;
using MediatR;
using MiddleTemplate.Application.Models;

namespace MiddleTemplate.Application.Features.Teas.Commands;

/// <param name="Name">
/// <example>Black tea</example>
/// </param>
/// <param name="Price">
/// <example>19.50$</example>
/// </param>
public record TeaUpdateCommand(string Name, string Price) : IRequest<TeaModel>
{
    [JsonIgnore] public Guid Id { get; init; }
}

internal class TeaUpdateCommandValidator : AbstractValidator<TeaUpdateCommand>
{
    public TeaUpdateCommandValidator()
    {
        RuleFor(o => o.Name).NotEmpty().MaximumLength(128);
        RuleFor(o => o.Price).NotEmpty();
    }
}