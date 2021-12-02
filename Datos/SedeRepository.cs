using Entidad;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class SedeRepository
    {
        DbConnection _connection;
        public SedeRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public List<Sede> ConsultarSedes()
        {
            List<Sede> sedes = new List<Sede>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Sede";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Sede sede = new Sede();
                    sede.Codigo = reader.GetString(0);
                    sede.Nombre = reader.GetString(1);
                    sedes.Add(sede);
                }
                reader.Close();
            }

            return sedes;
        }
    }
}
