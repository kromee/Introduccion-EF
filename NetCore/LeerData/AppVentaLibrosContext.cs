using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    public class AppVentaLibrosContext : DbContext
    {
        private const string connectionString = @"Data Source=192.168.1.86,1433; Initial Catalog=LibrosEF; user=sa; password=wincaja2023";
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libros>()
        .HasOne(l => l.PrecioPromocion)
        .WithOne(p => p.Libros)
        .HasForeignKey<Precios>(p => p.LibroId); // PrecioPromocion contiene la clave foránea


            modelBuilder.Entity<LibroAutor>().HasKey(xi => new {xi.AutorId, xi.LibroId});
        }

        public DbSet<Libros>? Libros {get;set;}
        public DbSet<Precios>? Precios {get;set;}
        public DbSet<Comentario>? Comentario {get;set;}
        public DbSet<Autor>? Autor {get;set;}
        public DbSet<LibroAutor>? LibroAutor {get;set;}
    }
}