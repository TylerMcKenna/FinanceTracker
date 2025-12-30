using Microsoft.EntityFrameworkCore;
using Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlite("Data source=finance.db"));

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "Hello World!");

app.MapPost("/category", CreateCategory);

static async Task<IResult> CreateCategory(Category category, AppDbContext db)
{
    db.Categories.Add(category);
    await db.SaveChangesAsync();
    return Results.Created($"/category/{category.Id}", category);
}

app.Run();
