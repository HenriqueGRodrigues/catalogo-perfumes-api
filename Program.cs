var builder = WebApplication.CreateBuilder(args);

// 1. Avisa o projeto para suportar Controladores
builder.Services.AddControllers();

var app = builder.Build();

// 2. Mapeia as rotas dos Controladores (como o nosso api/perfumes)
app.MapControllers();

app.Run();