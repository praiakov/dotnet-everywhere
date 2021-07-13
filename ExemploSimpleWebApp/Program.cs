using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", (Func<object>)(() => {
    const string mensagem = "Exemplo de uso de Minimal APIs em ASP.NET Core";
    var horario = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
    Console.WriteLine($"[{horario}] recebida requisição - {mensagem}");
    return new{
        Saudacao = "Bem-vindo ao .NET 6 Preview 4!",
        Descricao = mensagem,
        Horario = horario
    };
}));

app.Run();
