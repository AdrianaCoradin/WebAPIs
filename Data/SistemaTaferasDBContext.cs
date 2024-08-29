using Microsoft.EntityFrameworkCore;
using WebAPIs.Models;

namespace WebAPIs.Data
{
    public class SistemaTaferasDBContext : DbContext
    {
        public SistemaTaferasDBContext(DbContextOptions<SistemaTaferasDBContext> options)
        : base(options)
        
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
