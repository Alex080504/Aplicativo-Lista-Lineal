using AplicativoListas;
using System;

namespace Aplicativo.Lista.Circular
{
    public class ListaCircular
    {
        private Nodo fin;

        public ListaCircular()
        {
            fin = null;
        }

        public void Insertar(Object info)
        {
            Nodo nuevo = new Nodo(info);
            if (fin == null)
            {
                fin = nuevo;
                fin.Siguiente = fin;
            }
            else
            {
                nuevo.Siguiente = fin.Siguiente;
                fin.Siguiente = nuevo;
                fin = nuevo;
            }
        }

        public int Contar()
        {
            if (fin == null)
            {
                return 0;
            }

            if (fin.Siguiente.Equals(fin))
            {
                return 1;
            }
            int contador = 2;
            Nodo aux = fin.Siguiente;
            while (!aux.Siguiente.Equals(fin))
            {
                contador++;
                aux = aux.Siguiente;
            }

            return contador;
        }

        public void EliminarSegundo()
        {
            if (fin == null)
            {
                return;
            }
            if (fin.Siguiente.Equals(fin))
            {
                fin = null;
                return;
            }
            if (Contar() == 2)
            {
                Nodo aux2 = fin.Siguiente;
                aux2.Siguiente = aux2;
                fin = aux2;
                return;
            }

            Nodo aux = fin.Siguiente.Siguiente;
            fin.Siguiente.Siguiente = aux.Siguiente;

        }

        public string Reporte()
        {
            if (fin == null) return "Lista vacía";

            String r = "";
            Nodo aux = fin.Siguiente;
            do
            {
                Producto producto = (Producto)aux.Info;
                r += "Código: " + producto.Codigo + ", Nombre: " + producto.Nombre + ", Cantidad: " + producto.Cantidad + ", Precio: " + producto.Precio + ", Mínimo: " + producto.Minimo + Environment.NewLine;
                aux = aux.Siguiente;
            } while (aux != fin.Siguiente);

            return r;
        }
    }
}
