using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class SedeService
    {
        SedeRepository sedeRepository;
        ConnectionManager connectionManager;

        public SedeService(string connectionstring)
        {
            connectionManager = new ConnectionManager(connectionstring);
            sedeRepository = new SedeRepository(connectionManager.Connetion);
        }

        public List<Sede> ConsultarListSedes()
        {
            List<Sede> sedes = new List<Sede>();

            try
            {
                connectionManager.Open();
                sedes = sedeRepository.ConsultarSedes();
            }
            catch (Exception exception)
            {
                
            }
            finally
            {
                connectionManager.Close();
            }
            return sedes;
        }
    }
}
