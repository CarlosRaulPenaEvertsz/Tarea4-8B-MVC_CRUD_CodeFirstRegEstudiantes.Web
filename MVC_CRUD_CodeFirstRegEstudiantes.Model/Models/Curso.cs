using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_CodeFirstRegEstudiantes.Model.Models
{
    public class Curso
    {
        public int CursoID { get; set; }
        [Required(ErrorMessage = "La Descripción Obligatoria")]
        [MinLength(3, ErrorMessage = "La Descripción debe Tener al Menos 3 Caracteres")]
        public string Descripcion { get; set; }
        public virtual ICollection<Inscripcion> Inscripcions { get; set; }
    }
}
