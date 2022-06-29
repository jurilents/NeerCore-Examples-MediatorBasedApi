﻿using MediatR;
using NeerCore.Api;

namespace MiddleTemplate.Api.Controllers.Abstractions;

public abstract class MediatorController : ApiController
{
	private IMediator? _mediator;

	protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();
}