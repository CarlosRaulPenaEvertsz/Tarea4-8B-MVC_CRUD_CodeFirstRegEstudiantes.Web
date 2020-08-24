using MVC_CRUD_CodeFirstRegEstudiantes.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_CodeFirstRegEstudiantes.Model.DAL
{
    public class CargarDatosDB : System.Data.Entity.DropCreateDatabaseIfModelChanges<EstudiantesContext>
    {
        protected override void Seed(EstudiantesContext context)
        {
            var Estudiantes = new List<Estudiante>
            {
               new Estudiante{EstudianteID=1,Nombres="Carlos Raul",Apellidos="Peña Evertsz",Fecha_Inscripcion=DateTime.Parse("2020-07-15") },
            };

            Estudiantes.ForEach(s => context.Estudiantes.Add(s));
            context.SaveChanges();

            var Cursos = new List<Curso>
            {
                new Curso{CursoID=1,Descripcion="Diplomado C# MVC"},
            };
            Cursos.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();

            var Inscripcions = new List<Inscripcion>
            {
                new Inscripcion{InscripcionID=1,CursoID=1,EstudianteID=1,Semestre=1},
            };
            Inscripcions.ForEach(s => context.Inscripcions.Add(s));
            context.SaveChanges();


        }
    }
}
