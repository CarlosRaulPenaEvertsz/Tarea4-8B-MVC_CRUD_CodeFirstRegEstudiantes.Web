using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_CodeFirstRegEstudiantes.Model.Models
{
    public class Inscripcion
    {
        public int InscripcionID { get; set; }
        public int CursoID { get; set; }
        public int EstudianteID { get; set; }
        [Range(1, 2, ErrorMessage = "Semestre Incorrecto")]
        public int Semestre { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual Estudiante Estudiante { get; set; }
    }
}
