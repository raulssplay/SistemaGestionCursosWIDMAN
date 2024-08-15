using System;
using System.Collections.Generic;

namespace SistemaGestionCursos.Models
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public ICollection<Inscripcion> Inscripciones { get; set; }
    }
}
