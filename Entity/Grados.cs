using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entity
{
    internal class Grados
    {
        [PrimaryKey, Identity]
        public int idG { get; set; }
        public string NombreGrado { get; set; }



    }
}
