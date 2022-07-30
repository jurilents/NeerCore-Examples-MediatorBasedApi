using MediatR;
using MiddleTemplate.Application.Models;

namespace MiddleTemplate.Application.Features.Teas.Queries;

public class TeaByIdQuery : IRequest<TeaModel>
{
	public Guid Id { get; }

	public TeaByIdQuery(Guid id) => Id = id;
}