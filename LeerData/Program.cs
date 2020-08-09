using System.Reflection;
using System.Net.WebSockets;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {

            using(var db = new AppVentaCursosContext()){
                var cursos = db.Curso.Include(c=>c.InstructorLink).ThenInclude(ci=>ci.Instructor).AsNoTracking();
                foreach (var curso in cursos)
                {
                    System.Console.WriteLine(curso.Titulo);
                    foreach(var link in curso.InstructorLink){
                        System.Console.WriteLine("*****"+link.Instructor.Nombre);
                    }
                }
            }
            // using(var db = new AppVentaCursosContext()){
            //     var cursos = db.Curso.Include(c=> c.ComentarioLista).AsNoTracking();
            //     foreach (var curso in cursos)
            //     {
            //         System.Console.WriteLine(curso.Titulo);
            //         foreach(var comentario in curso.ComentarioLista){
            //             System.Console.WriteLine("**********"+comentario.ComentarioTexto);
            //         }
            //     }
            // }

            // using(var db = new AppVentaCursosContext()){
            //     var cursos = db.Curso.Include(p=> p.PrecioPromocion).AsNoTracking();

            //     foreach(var curso in cursos){
            //         Console.WriteLine(curso.Titulo+"------"+curso.PrecioPromocion.PrecioActual);
            //     }
            // }


            // using(var db = new AppVentaCursosContext()){
            //     var cursos = db.Curso.AsNoTracking();//pide la data y la entrega sin guardar en memoria (arreglo de tipo IQueryable)

            //     foreach (var curso in cursos)
            //     {
            //         System.Console.WriteLine(curso.Titulo + "---"+curso.Descripcion);
            //     }}
            

        }
    }
}
