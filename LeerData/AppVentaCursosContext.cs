using System.Reflection.Emit;
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
        
        //indica que tenemos dos llaves foraneas
         protected override void OnModelCreating(ModelBuilder modelBuilder){
             modelBuilder.Entity<CursoInstructor>().HasKey(ci=>new{ci.CursoId,ci.InstructorId});
         }
        //convierte en una entidad a la clase curso
         public DbSet<Curso> Curso{get; set;}
         public DbSet<Precio> Precio{get; set;}
         public DbSet<Comentario> Comentario{get; set;}
         public DbSet<Instructor> Instructor{get;set;}
         public DbSet<CursoInstructor> CursoInstructor{get;set;}
        
    }
}