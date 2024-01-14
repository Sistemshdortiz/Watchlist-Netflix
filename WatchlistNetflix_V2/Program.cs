using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WatchlistNetflix_V2.Context;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Servicio de BBDD con MySql
//builder.Services.AddDbContext<AplicationDBContext>(options => options.UseMySql(Configuration.GetConnectionString("watchlistddbbconnection")));
builder.Services.AddDbContext<AplicationDbContext>(configuracion =>

    configuracion.UseMySql(
    builder.Configuration["ConnectionStrings:watchlistddbbconnection"],
    new MySqlServerVersion(new Version(8, 0, 30)) // O la versión de tu servidor MySQL
));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
