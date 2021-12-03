using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class InventarioSedeService
    {
        InventarioSedeRepository inventarioSedeRepository;
        ConnectionManager connectionManager;

        public InventarioSedeService()
        {
        }

        public InventarioSedeService(string connectionstring)
        {
            connectionManager = new ConnectionManager(connectionstring);
            inventarioSedeRepository = new InventarioSedeRepository(connectionManager.Connetion);
        }

        

        public string GuardarArchivo(string archivo)
        {          
            try
            {
                if (inventarioSedeRepository.MapearArchivo(archivo) != null)
                {
                    inventarioSedeRepository.CargarArchivo();
                    return "Secargó el archivo a la tabla correctamente!";
                }
                else
                {
                    return "ERROR al mapear el archivo";
                }              
            }
            catch (Exception exception)
            {

                return "Se presentó el siguiente error:" + exception.Message;
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public BusquedaReponseInventario ConsultarInventarioPorSedes(string sede)
        {
            try
            {
                connectionManager.Open();
                return new BusquedaReponseInventario(inventarioSedeRepository.ConsultarInventario(sede));
            }
            catch (Exception exception)
            {
                return new BusquedaReponseInventario("Se presentó el siguiente error:" + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }

    }
    public class BusquedaReponseInventario
    {
        public List<InventarioSede> InventarioSedes { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public BusquedaReponseInventario(List<InventarioSede> inventarioSedes)
        {
            InventarioSedes = inventarioSedes;
            Error = false;
        }

        public BusquedaReponseInventario(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }
}
