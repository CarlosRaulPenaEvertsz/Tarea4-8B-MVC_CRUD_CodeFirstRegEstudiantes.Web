using MVC_CRUD_CodeFirstRegEstudiantes.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_CodeFirstRegEstudiantes.Model.DAL
{
    public class EstudiantesContext : DbContext
    {
        public EstudiantesContext()
            : base("EstudiantesContext")
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Inscripcion> Inscripcions { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
