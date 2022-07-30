using MediatR;
using NeerCore.Application.Abstractions;

namespace MiddleTemplate.Application.Features.Teas.Commands;

public record struct TeaDeleteCommand(Guid Id) : ICommand;