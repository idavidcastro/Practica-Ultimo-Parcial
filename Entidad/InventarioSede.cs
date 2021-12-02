using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class InventarioSede
    {
        public Sede CodigoSede { get; set; }
        public Producto CodigoProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
