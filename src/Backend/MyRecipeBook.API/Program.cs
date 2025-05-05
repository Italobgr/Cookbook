using MyRecipeBook.API.Filters;
using MyRecipeBook.API.Middlewere;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//faz a api escutar qq exception gerada e executar o filtro
builder.Services.AddMvc(options => options.Filters.Add(typeof(ExceptionFilter))); //typeoff se molda para um typo expecifico
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<CultureMidlewere>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
