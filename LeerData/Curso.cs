
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Collections.Generic; 
namespace LeerData
{
    public class Curso 
    {
        public int CursoId {get;set;}
        public string Titulo{get;set;}
        public string Descripcion{get; set;}
        public DateTime FechaPlublicacion{get;set;}
        public Precio PrecioPromocion{get;set;}//crear referencia a objeto referenciado en SQL
        public ICollection<Comentario> ComentarioLista{get;set;}

        public ICollection<CursoInstructor> InstructorLink {get;set;}

    }
}