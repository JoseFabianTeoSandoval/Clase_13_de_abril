using Clase_13_de_abril.Clase_base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_de_abril.Clase_hija
{
    internal class PlayStation : Consola
    {
        public string ModeloControlador { get; set; }
        public string MostrarDetallesPS()
        {
            Mostrardetalles();
            return $"Modelo de controlador {ModeloControlador}";
        }
    }
}
