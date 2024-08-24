using Microsoft.EntityFrameworkCore;

namespace BicliotecaDocker.Models
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : DbContext(options)
    {
        public DbSet<Autor> Autores { get; set; } = null!;
        public DbSet<Libro> Libro { get; set; } = null!;
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
