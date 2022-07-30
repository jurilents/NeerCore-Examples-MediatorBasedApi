﻿using MediatR;
using MiddleTemplate.Application.Models;

namespace MiddleTemplate.Application.Features.Teas.Queries;

public class TeaByFilterQuery : IRequest<IEnumerable<TeaModel>>
{
	public string Filters { get; init; } = default!;
	public string Sorts { get; init; } = "id";
	public int Page { get; init; } = 1;
	public int PageSize { get; init; } = 10;
}