﻿using Mapster;
using MediatR;
using MiddleTemplate.Application.Features.Teas.Commands;
using MiddleTemplate.Application.Models;
using MiddleTemplate.Data.Entities;
using NeerCore.Data.EntityFramework.Abstractions;

namespace MiddleTemplate.Application.Features.Teas.Handlers;

public class TeaUpdateHandler : IRequestHandler<TeaUpdateCommand, TeaModel>
{
    private readonly IDatabaseContext _database;
    public TeaUpdateHandler(IDatabaseContext database) => _database = database;

    public async Task<TeaModel> Handle(TeaUpdateCommand request, CancellationToken cancel)
    {
        var entity = request.Adapt<Tea>();
        _database.Set<Tea>().Add(entity);
        await _database.SaveChangesAsync(cancel);
        return entity.Adapt<TeaModel>();
    }
}