using Microsoft.EntityFrameworkCore;
using Path = System.IO.Path;

var builder = WebApplication.CreateBuilder(args);

var folder = Environment.SpecialFolder.LocalApplicationData;
var path = Environment.GetFolderPath(folder);
var dbPath = Path.Join(path, "hc-project-children.db");

Console.WriteLine($"DB Path: {dbPath}");

builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlite($"Data Source={dbPath}"));

builder.Services
    .AddGraphQLServer()
    .ModifyRequestOptions(options => options.IncludeExceptionDetails = builder.Environment.IsDevelopment())
    .AddTypes()
    .RegisterDbContext<DatabaseContext>()
    .AddProjections();

var app = builder.Build();

// Create DB.
using var scope = app.Services.CreateScope();
using var context = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
context.Database.EnsureCreated();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
