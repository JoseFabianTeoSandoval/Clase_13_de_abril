using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_de_abril.Clase_base
{
    internal class Consola
    {
        public string Marca { get; set; }
        public int anioLanzamiento { get; set; }
        public void Mostrardetalles()
        {
            Console.WriteLine($"Marca: {Marca}, año de lanzamiento: {anioLanzamiento}");
        }
    }
}
