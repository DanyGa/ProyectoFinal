using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.EstructurasdeDatos.CPilas
{
    class Pila
    {
        private Nodo top;

        public Nodo Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }

        public int Count
        {
            get
            {
                int c = 0;
                Nodo t = top;
                while (top != null)
                {
                    c++;
                    //aqui hay un error
                    t = t.Siguiente;
                }
                return c;
            }
        }

        public Pila()
        {
            top = null;
        }

        public void Push(Nodo n)
        {
            n.Siguiente = top;
            top = n;
        }

        public Nodo Pop()
        {
            Nodo regreso = null;
            if (top != null)
            {
                top = top.Siguiente;
            }
            return regreso;
        }
        public override string ToString()
        {
            string lista = "";
            Nodo t = top;
            if (t != null)
            {
                lista += t.ToString();
                t = t.Siguiente;
                while (t != null)
                {
                    lista += "," + t.ToString();
                    t = t.Siguiente;
                }
                lista += ".";
                lista = lista.Replace(".", "");
                return lista;

            }
            else
            {
                return "La lista esta vacia";
            }
        }
    }
}
