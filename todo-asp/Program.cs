using ConfigurationManager = System.Configuration.ConfigurationManager;
using DAL;


// main
var config = ConfigurationManager.AppSettings;

if (config == null || config.Count == 0)
{
    throw new Exception("Config is missing or empty");
}


var conenctionString = config["ConnectionString"];

if (conenctionString == null)
{
    throw new Exception("Connection string not found !");
}

using (var db = new TodoDbContext(conenctionString))
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
