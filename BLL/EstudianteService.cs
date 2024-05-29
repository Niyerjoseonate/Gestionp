using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using DALL;

namespace BLL
{     
   
    public class EstudianteService
    {
        private ConnectionManager conexion;
        private EstudianteRepository estudianterepository;
        List<Estudiantes> estudiantelista;
        Estudiantes estudiantes;

        public EstudianteService(string connectionString) { 
        
            conexion = new ConnectionManager(connectionString);
            estudianterepository = new EstudianteRepository(conexion);

        }

        public List<Estudiantes> Consultar()
        {
            try
            {
                estudiantelista = new List<Estudiantes>();
                conexion.Open();
                estudiantelista = estudianterepository.Consultar();
                return estudiantelista;

            }
            catch (Exception e)
            {

                string Mensaje = $"error de datos" + e.Message.ToString();


            }
            finally
            {
                conexion.Close();
            }
            return null;
        }


    }
}
