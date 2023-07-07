using Repository.Connection;
using Repository.Contracts;
using Repository.Repositories;
using Service.Contracts;
using Service.Services;
using WEGGAPI.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IConnectionFactory, ConnectionFactory>();

builder.Services.AddSingleton<ICorretorService, CorretorService>();
builder.Services.AddSingleton<ICorretorRepository, CorretorRepository>();

builder.Services.AddSingleton<IUsuarioService, UsuarioService>();
builder.Services.AddSingleton<IUsuarioRepository, UsuarioRepository>();

builder.Services.AddSingleton<IImovelService, ImovelService>();
builder.Services.AddSingleton<IImovelRepository, ImovelRepository>();

builder.Services.AddSingleton<IWhatsappService, WhatsappService>();

builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

app.UseExceptionHandler(new ExceptionHandlerOptions
{
    ExceptionHandler = new ExceptionMiddleware(app.Environment).Invoke
}
);

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
