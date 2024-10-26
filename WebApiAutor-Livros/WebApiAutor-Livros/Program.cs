using Microsoft.EntityFrameworkCore;
using WebApiAutor_Livros.Data;
using WebApiAutor_Livros.Services.Autor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Injeção de dependência para a interface se comunicar com a classe, os métodos que estão na interface serão utilizados pela classe
builder.Services.AddScoped<IAutorInterface, AutorService>();

// Configuração para definir o banco de dados e para a classe receber a string de conexão
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection"));
});

var app = builder.Build();

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
