using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Lista
    {
        public Nodo cabeza;

        public void Insertar(Libro libro)
        {
            Nodo nuevo = new Nodo(libro);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.siguiente != null) 
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = nuevo;
            }
        }

        public string Imprimir()
        {
            Nodo actual = cabeza;
            string resultado = "";

            while (actual!= null)
            {
                resultado += actual.dato.Codigo; //Se llama a nodo que a la vez llama a libro (codigo)->Lista enlazada

                if (actual.siguiente != null) {
                    resultado += "->";
                }
                actual = actual.siguiente;
            }
            if (resultado == "")
            {
                resultado = "Lista vacia :(";
            }
            return resultado;
        }

        public bool Buscar(string codigo) 
        {
            Nodo actual = cabeza;
            
            while (actual != null)
            {
                if (actual.dato.Codigo==codigo)
                {
                    return true;
                }
                actual = actual.siguiente;
            }
            return false;
        }
    }
}
