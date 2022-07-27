using Microsoft.Extensions.DependencyInjection;
using projeto_stefanini.Context;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("StefaniniDb")
          ?? "Data Source=Stefanini.db";


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSqlServer<ContextoPessoa>(connectionString);
builder.Services.AddSqlServer<ContextoCidade>(connectionString);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

  builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder => {
            builder
                .AllowAnyHeader()
                .AllowAnyOrigin()
                .AllowAnyMethod();
        }
    );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



app.Run();
