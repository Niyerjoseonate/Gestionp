using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Docentes
    {
        [Identity]
        public int idD { get; set; }
        public string NombreDocente { get; set; }
        public string ApellidoDocente { get; set; }
        [PrimaryKey]
        public string DocenteNid { get; set; }
        public string FechaDeNacimientoDocente { get; set; }
        public string DireccionDocente { get; set; }
        public string Especialidad { get; set; }
        public string TelefonoDocente { get; set; }

    }
}
