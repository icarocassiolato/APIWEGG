using Repository.Connection;
using Repository.Contracts;
using Repository.Repositories;
using Service.Contracts;
using Service.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IConnectionFactory, ConnectionFactory>();

builder.Services.AddSingleton<ICorretorService, CorretorService>();
builder.Services.AddSingleton<ICorretorRepository, CorretorRepository>();

builder.Services.AddSingleton<IUsuarioService, UsuarioService>();
builder.Services.AddSingleton<IUsuarioRepository, UsuarioRepository>();

builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection()
    .UseCors("AllowAllHeaders")
    .UseAuthentication()
    .UseAuthorization();

app.MapControllers();

app.Run();
