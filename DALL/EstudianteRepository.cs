using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using DAL;
using System.Data;

namespace DALL
{
    public class EstudianteRepository
    {
       SqlConnection conn;
        List<Estudiantes> estudiantes;

        public EstudianteRepository(ConnectionManager connection)
        {
            conn = connection.connection;
            estudiantes = new List<Estudiantes>();  
        }

        public  List<Estudiantes> Consultar() {

            estudiantes.Clear();
            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "Select * from Estudiante";
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                    {
                    Estudiantes estudiante = new Estudiantes();
                    estudiante = Mapear(Reader);
                    estudiantes.Add(estudiante);
                } 
            }
            return estudiantes; 
        }
        public Estudiantes Mapear(SqlDataReader reader)
        {
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.idE =Convert.ToInt32(reader["IdEs"]);
            estudiantes.EstudianteNid = (string)reader["EstudianteNid"];
            estudiantes.NombreEstudiante = (string)reader["NombreEstudiante"];
            estudiantes.ApellidoEstudiante = (string)reader["ApellidoEstudiante"];
            estudiantes.FechaDeNacimientoEstudiante = (string)reader["FechNacEstudiante"];
            estudiantes.DireccionEstudiante = (string)reader["DirEstudiante"];
            estudiantes.TelefonoEstudiante = (string)reader["TelfEstudiante"];
            estudiantes.CorreoElectronico = (string)reader["EmailEstudiante"];

            return estudiantes;
        }



    }
}
