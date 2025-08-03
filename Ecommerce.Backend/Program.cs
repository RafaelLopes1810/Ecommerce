using Ecommerce.Backend.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

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
