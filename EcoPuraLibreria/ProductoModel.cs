using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoPuraLibreria
{
    public class ProductoModel
    {
        public string Descripcion { get; set; }
        public int CodigoBarras { get; set; }
        public string Proveedor { get; set; }
        public string Clasificacion { get; set; }
        public int Costo { get; set; }
        public int Precio { get; set; }
        public int Existencia { get; set; }
        public int Minimo { get; set; }
        public int Maximo { get; set; }
    }
}