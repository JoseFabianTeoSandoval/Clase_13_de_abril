using Clase_13_de_abril.Clase_base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_de_abril.Clase_hija
{
    internal class Nintendo : Consola
    {
        public bool Esportatil { get; set; }
        public string MostrarDetallesNintendo()
        {
            Mostrardetalles();
            return $"Es portatil: {Esportatil}";
        }
    }
}
