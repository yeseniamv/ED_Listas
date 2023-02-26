using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    internal class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;
        Nodo nodoAtras;
        public Lista()
        {
            nodoInicial = new Nodo();
        }
        public bool ValidaVacio()
        {
            if (nodoInicial.Siguiente == null)
                return true;
            else
                return false;
            //return nodoInicial.Siguiente == null;

        }
        public void VaciarLista()
        {
            nodoInicial.Siguiente = null;
        }
        public string Recorrer()
        {
            string datos = string.Empty;
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                datos += nodoActual.Valor + "\n";
            }
            return datos;
        }
        public void Agregar(string valor)
        {
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }
            Nodo nodoNuevo = new Nodo(valor);
            nodoActual.Siguiente = nodoNuevo;
        }
        public String Buscar(string valor)
        {
            if (ValidaVacio() == true)
                return null;

            int indice = 0;
            string indicen = "";
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                indice++;
                indicen = indice.ToString();
                if (nodoActual.Valor == valor)
                {
                    
                    return indicen;
                }

            }
            return null;
        }

        public void AgregarInicio(string valor)
        {
            //creamos nuevo nodo

            nodoActual = nodoInicial;
            Nodo nodoNuevo = new Nodo(valor);
            //conectamos nuevo nodo al primer nodo de la lista
            nodoNuevo.Siguiente = nodoActual.Siguiente;
            //conectamos nodo inicial con nodo nuevo
            nodoInicial.Siguiente = nodoNuevo;


        }

        
        //borrar ultimo agregado
        public void Borrar()
        {
            if (ValidaVacio() == true)
                return ;
            

            nodoAtras = nodoInicial;
            nodoActual = nodoInicial.Siguiente;

            while (nodoActual.Siguiente != null)
            {
                nodoAtras = nodoActual;
                nodoActual = nodoActual.Siguiente;
            }
            
            nodoAtras.Siguiente = null;
            
        }

        //borrar al inicio
        public void BorrarInicio()
        {
            if (ValidaVacio() == true)
                return;
            //colocamos nodo atras al inicio
            nodoAtras = nodoInicial.Siguiente;
            //avansamos dos espacios
            nodoActual = nodoInicial.Siguiente;
            nodoActual = nodoActual.Siguiente;
            
           
            
            //conectamos nuevo nodo al primer nodo de la lista
            nodoInicial.Siguiente = nodoActual;
            //eliminamos el primer nodo
            nodoAtras.Siguiente = null;


        }


    }

}
