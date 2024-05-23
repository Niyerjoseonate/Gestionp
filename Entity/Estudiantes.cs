using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Estudiantes
    {
        [Identity]
        public int idE {get; set;}
        public string NombreEstudiante { get; set; }
        public string ApellidoEstudiante { get; set; }
        [PrimaryKey]
        public string EstudianteNid { get; set; }
        public string FechaDeNacimientoEstudiante { get; set; }
        public string DireccionEstudiante { get; set; }
        public string TelefonoEstudiante { get; set; }
        public string x { get; set; }
        public string CorreoElectronico { get; set; }



    }
}
