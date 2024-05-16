using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Mapping;

namespace Entity
{
    internal class Materias
    {
        [PrimaryKey, Identity]
        public int idM { get; set; }

        public string NombreMaterias { get; set; }




    }
}
