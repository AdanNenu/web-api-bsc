using EmpresaBSC.Components;
using EmpresaBSC.Data;
using Microsoft.EntityFrameworkCore;

namespace EmpresaBSC;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        //Agrega el contexto de conexión de base de datos de la empresa CBS
        builder.Services.AddDbContext<CBSDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("MiConexionCBS")));

        builder.Services.AddControllers();
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.MapControllers();
        app.Run();
    }
}
