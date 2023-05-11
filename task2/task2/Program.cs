using Microsoft.EntityFrameworkCore;
using task2.DataAccessLayer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-631CTLQ\\SQLEXPRESS;Database=task2Db;Trusted_Connection=true;");
});
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();
