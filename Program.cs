
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

            //Conex�o com o bd
            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<SistemaTaferasDBContext>(
                    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
                );
            // Config depend�ncias reposit�rio
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
