using Ecommerce.Backend.Infrastructure.Persistence;
using Ecommerce.Backend.Domain.Interfaces;
using Ecommerce.Backend.Application.Services;
using Ecommerce.Backend.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona services e repositórios
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

// Conexão com o banco de dados
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adiciona controllers
builder.Services.AddControllers();

var app = builder.Build();

// Redireciona HTTP para HTTPS
app.UseHttpsRedirection();

// Mapeia endpoints dos controllers
app.MapControllers();

app.Run();
