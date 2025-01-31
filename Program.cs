
using Microsoft.EntityFrameworkCore;
using WebAPIs.Data;
using WebAPIs.Repositorios;
using WebAPIs.Repositorios.Interfaces;

namespace WebAPIs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Conexão com o bd
            builder.Services.AddDbContext<SistemaTarefasDBContext>(options =>
            {
                options.UseSqlServer("Data source=DESKTOP-CR06JKF\\SQLSERVER;Initial Catalog=SistemaTarefasDBContext;User Id=sa;Password=adri;TrustServerCertificate=True;MultipleActiveResultSets=true");
            });


            builder.Services.AddScoped<ITarefaRepositorio, TarefaRepositorio>();
            builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
