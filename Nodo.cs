using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Nodo
    {
        public Libro dato;
        public Nodo siguiente;

        public Nodo(Libro libro)
        {
            dato = libro;
            siguiente= null;
        }


    }
}
