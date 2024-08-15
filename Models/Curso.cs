using System;
using System.Collections.Generic;

namespace SistemaGestionCursos.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public ICollection<Inscripcion> Inscripciones { get; set; }
    }
}
