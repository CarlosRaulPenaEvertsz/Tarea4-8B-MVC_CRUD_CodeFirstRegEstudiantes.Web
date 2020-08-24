using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD_CodeFirstRegEstudiantes.Model.Models
{
    public class Estudiante
    {
        public int EstudianteID { get; set; }
        [Required(ErrorMessage = "El Nombre es Obligatorio")]
        [MinLength(3, ErrorMessage = "El Nombre del Estudiante debe Tener al Menos 3 Caracteres")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El Apellido es Obligatorio")]
        [MinLength(3, ErrorMessage = "El Apellido del Estudiante debe Tener al Menos 3 Caracteres")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "La Fecha de Inscripcion es Obligatoria")]
        public DateTime Fecha_Inscripcion { get; set; }
        public virtual ICollection<Inscripcion> Inscripcions { get; set; }
    }
}
