using Microsoft.EntityFrameworkCore;
using Models;
using DTOs;

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


// to be abstracted into services
app.MapGet("/", () => "Hello World!");
app.MapPost("/category", CreateCategory);

// to be abstracted into services
static async Task<IResult> CreateCategory(CategoryDTO categoryDTO, AppDbContext db)
{
    var category = new Category
    {
        CategoryName = categoryDTO.CategoryName
    };

    db.Categories.Add(category);
    await db.SaveChangesAsync();

    var responseCategory = new CategoryDTO
    {
        Id = category.Id,
        CategoryName = category.CategoryName
    };

    // // Factory pattern
    return TypedResults.Created($"/category/{category.Id}", responseCategory);
}

app.Run();
