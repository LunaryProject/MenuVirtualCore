using LunaryCore.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Contexto>(options => options.UseSqlServer
("Data Source=mssql2016.hostingzone.com.br;Initial Catalog=lunary;user id=lunary;password=lunary;Integrated Security=True;Encrypt=False"));
//("Data Source=.\\SENAI;Initial Catalog=BancoDeDados;Integrated Security=True;Encrypt=False"));
//("Data Source=10.139.166.53\\SENAI;Initial Catalog=BancoDeDados;Integrated Security=True;Encrypt=False"));


var app = builder.Build();

//// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Admin}/{action=index}/{id?}");

app.Run();
