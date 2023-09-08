using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore; 
using MOTORED2.Server;
using MOTORED2.Server.Models;
using MOTORED2.Server.Servicios.Contrato;
using MOTORED2.Server.Servicios.Implementacion; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<MotoredContext>(options => 
{ options.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL")); 
});
//Se realiza la conexion con el app setting que contiene                                                                                                    
//la cadena de conexion que conecta con la bd de sql

builder.Services.AddScoped<IUsuarioService, UsuarioService>(); //Implementamos clase con su interfaz para poder utilizarla
                                                               //en los demas controladores
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
