using Microsoft.EntityFrameworkCore;
using NeerCore.Data.EntityFramework.Abstractions;
using NeerCore.Data.EntityFramework.Extensions;

namespace MiddleTemplate.Data.Context;

public class SqliteDbContext : DbContext, IDatabaseContext
{
    public SqliteDbContext(DbContextOptions options) : base(options)
    {
        // Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyAllConfigurations();
        builder.ApplyAllDataSeeders();
    }
}