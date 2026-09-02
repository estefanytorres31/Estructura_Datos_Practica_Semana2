using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Libro
    {
        public string Codigo { get; set; }
        public Nodo siguiente { get; set; }

        public Libro (string codigo)
        {
            Codigo = codigo;
            siguiente = null;
        }

    }
}
