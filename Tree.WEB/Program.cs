using Tree.Logic;
using Tree.DAL.Repositories;
using Tree.DAL.Repositories.Abstract;
using Tree.PostgresMigrator;
using Microsoft.EntityFrameworkCore;
using static Tree.DAL.TreeDAL;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("NpgsqlConnectionString");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<GenreService>();
builder.Services.AddScoped<IGenreRepository, GenreRepository>();

PostgresMigrator.Migrate(connectionString);
builder.Services.AddDbContext<PostgreeContext>(options => options.UseNpgsql(connectionString));

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
