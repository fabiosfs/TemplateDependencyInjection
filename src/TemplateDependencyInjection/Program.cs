using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TemplateDependencyInjection.Domain.Domains;
using TemplateDependencyInjection.Domain.Interfaces;
using TemplateDependencyInjection.Domain.Mapper;
using TemplateDependencyInjection.Infrastructure.Contexts;
using TemplateDependencyInjection.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<ClientMapper>();
});

var mapper = configuration.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddDbContextPool<FirstDbContext>(options =>
           options.UseSqlServer(builder.Configuration.GetSection("ConnectionsStrings:FirstDb").Value));

builder.Services.AddTransient<IClientRepository, ClientRepository>();

builder.Services.AddTransient<IClientDomain, ClientDomain>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider
        .GetRequiredService<FirstDbContext>();

    // Here is the migration executed
    dbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
