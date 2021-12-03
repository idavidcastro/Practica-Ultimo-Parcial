using Entidad;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class InventarioSedeRepository
    {
        
        DbConnection _connection;
        public InventarioSedeRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public InventarioSede MapearArchivo(string archivo)
        {
            FileStream file = new FileStream(archivo, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(file);
            string linea;
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                InventarioSede inventarioSede = new InventarioSede();
                {
                    inventarioSede.CodigoSede.Codigo = dato[0];
                    inventarioSede.CodigoProducto.Codigo = dato[1];
                    inventarioSede.Cantidad = int.Parse(dato[2]);
                    return inventarioSede;
                }; 
            }
            lector.Close();
            file.Close();
            return null;
        }

        public void CargarArchivo()
        {
            InventarioSede inventarioSede = new InventarioSede();

            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into InventarioSede(CodigoSede, CodigoProducto, Cantidad) " +
                                      "values(@CodigoSede, @CodigoProducto, @Cantidad)";
                command.Parameters.Add(new SqlParameter("@CodigoSede", inventarioSede.CodigoSede));
                command.Parameters.Add(new SqlParameter("@CodigoProducto", inventarioSede.CodigoProducto));
                command.Parameters.Add(new SqlParameter("@Cantidad", inventarioSede.Cantidad));

                command.ExecuteNonQuery();
            }
        }
        public List<InventarioSede> ConsultarInventario(string sede)
        {
            List<InventarioSede> inventarioSedes = new List<InventarioSede>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select *from InventarioSede where CodigoSede=@CodigoSede;";
                command.Parameters.Add(new SqlParameter("@CodigoSede", sede));
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    InventarioSede inventarioSede = new InventarioSede();
                    inventarioSede.CodigoSede.Codigo = reader.GetString(0);
                    inventarioSede.CodigoProducto.Codigo = reader.GetString(1);
                    inventarioSede.Cantidad = int.Parse(reader.GetString(2));

                    inventarioSedes.Add(inventarioSede);
                }
                reader.Close();
            }
            return inventarioSedes;
        }
    }
    }
