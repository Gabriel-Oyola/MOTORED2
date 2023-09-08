using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore; 
using MOTORED2.Server;
using MOTORED2.Server.Models;
using MOTORED2.Server.Servicios.Contrato;
using MOTORED2.Server.Servicios.Implementacion;

using Microsoft.AspNetCore.Authentication.Cookies; //Using para poder trabajar con cookies 
using Microsoft.AspNetCore.Mvc; 


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

//Configuramos la autenticacion 
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option =>
    {
        option.LoginPath = "/Inicio/IniciarSesion";
        option.ExpireTimeSpan= TimeSpan.FromMinutes(20);
    }
    );
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

//Habilitamos la autenticacion
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Inicio}/{action=IniciarSesion}/{id?}"
    );
//app.MapFallbackToFile("index.html");

app.Run();
