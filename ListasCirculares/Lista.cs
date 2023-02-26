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
        Nodo nodoExtra;
        
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
            //se colo nuevo nodo al final de la lista
            nodoActual.Siguiente = nodoNuevo;
            //se define la coneccion del nodo final con el primero
            nodoNuevo.Final = nodoInicial.Siguiente;
            //se elimina coneccion con el primero del ahora penultimo nodo
            nodoActual.Final = null;
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
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }
            Nodo nodoNuevo = new Nodo(valor);
            //se colo nuevo nodo en la coneccion final activa
            nodoActual.Final = nodoNuevo;
            //se coloca nodo coneccion con el primero de la lista
            nodoNuevo.Siguiente = nodoInicial.Siguiente;
            //se conecta el nodo plantilla(antes del comenzo) con el nuevo nodo
            //por ser el nuevo primero
            nodoInicial.Siguiente = nodoNuevo;



        }


        //borrar ultimo agregado
        public void Borrar()
        {
            if (ValidaVacio() == true)
                return ;
            

            nodoExtra = nodoInicial;
            nodoActual = nodoInicial.Siguiente;

            while (nodoActual.Siguiente != null)
            {
                nodoExtra = nodoActual;
                nodoActual = nodoActual.Siguiente;
            }
            //se elimina coneccion del penultimo con el primero
            nodoExtra.Siguiente = null;
            //se conecta el nuevo ultimo de la lista con el primero de la lista
            nodoExtra.Final = nodoInicial.Siguiente;
            //se elimina coneccion del anterior nodo final con el comienzo
            nodoActual.Final = null;
            
        }

        //borrar al inicio
        public void BorrarInicio()
        {
            if (ValidaVacio() == true)
                return;
            //colocamos nodo de apoyo en el nodo segundo
            nodoExtra = nodoInicial.Siguiente;
            nodoExtra = nodoExtra.Siguiente;
            //ponemos segundo nodo de apoyo al final de la lista
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }
            //conectamos coneccion del final con el nuevo primer nodo
            nodoActual.Final = nodoExtra;
            //cambiamos segundo nodo de apoyo al nodo a borrar
            nodoActual = nodoInicial.Siguiente;
            //anulamos coneccion del primero con el segundo
            nodoActual.Siguiente= null;

            //conectamos nodo platilla al segundo nodo de la lista
            nodoInicial.Siguiente = nodoExtra;


        }


    }

}
