using Clase_13_de_abril.Clase_base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_de_abril.Clase_hija
{
    internal class Xbox : Consola
    {
        public bool GamePass { get; set; }

        public string MostrarDetallesXbox()
        {
            Mostrardetalles();
            return $"Tiene Game Pass: {GamePass}";
        }
    }
}
