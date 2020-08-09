using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    public class AppVentaCursosContext : DbContext
    {
        private const string connectionString = @"Data Source=BERNISTATION-PC; Initial Catalog=CursosOnline; Integrated Security=True";

         protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
             optionBuilder.UseSqlServer(connectionString);
         }
        //convierte en una entidad a la clase curso
         public DbSet<Curso> Curso{get; set;}
         public DbSet<Precio> Precio{get; set;}
         public DbSet<Comentario> Comentario{get; set;}
        
    }
}