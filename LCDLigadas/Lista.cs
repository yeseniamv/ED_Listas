using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCDLigadas
{
    internal class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;
        Nodo nodoFinal;
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
            nodoExtra = nodoInicial.Siguiente;
            nodoExtra.Anterior = null;
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
            //colocar el nuevo nodo al final de la lista
            nodoActual.Siguiente = nodoNuevo;
            
            //definir el nuevo nodo final de la lista
            nodoFinal = nodoNuevo;
            //enlazar el nuevo nodo con su anterior
            nodoNuevo.Anterior = nodoActual;
            //enlazamos nuevo nodo final con nodo incial
            nodoNuevo.Final = nodoInicial.Siguiente;
            //eliminamos coneccion del anterior ultimo nodo con el comienzo de la lista
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


            nodoExtra = nodoInicial.Siguiente;
            //creamos nuevo nodo
            Nodo nodoNuevo = new Nodo(valor);
            //conectamos nodo inicial con nodo nuevo
            nodoInicial.Siguiente = nodoNuevo;
            //conectamos nodo nuevo con nodo inicial 
            nodoNuevo.Anterior = nodoInicial;
            //conectamos el anterior primer nodo de la lista al nuevo nodo
            nodoExtra.Anterior = nodoNuevo;
            //conectamos nuevo nodo al primer nodo de la lista
            nodoNuevo.Siguiente = nodoExtra;
            //se redefine la coneccion del final con el nuevo inicial
            nodoFinal.Final = nodoNuevo;




        }


        //borrar ultimo agregado
        public void Borrar()
        {
            if (ValidaVacio() == true)
                return;

            //colocamos el nodo de apoyo sobre el nodo anterior al ultimo
            nodoActual = nodoFinal.Anterior;
            //quitamos coneccion del penultimo nodo con el ultimo
            nodoActual.Siguiente = null;
            //quitamos conexion del ultimo nodo con el anterior
            nodoFinal.Anterior = null;
            //se borra coneccion del anterior final con el inicial
            nodoFinal.Final = null;
            //usamos el nodo de apoyo para redefinir quien es el nodo final
            nodoFinal = nodoActual;
            //se hace coneccion del nuevo final con el inicial
            nodoFinal.Final = nodoInicial.Siguiente;

        }

        //borrar al inicio
        public void BorrarInicio()
        {
            if (ValidaVacio() == true)
                return;
            //colocamos nodo de apoyo al inicio
            nodoExtra = nodoInicial.Siguiente;
            //colocamos segundo nodo de apoyo despues de este
            nodoActual = nodoInicial.Siguiente;
            nodoActual = nodoActual.Siguiente;



            //conectamos el comienzo en el nodo de la segunda posicion
            nodoInicial.Siguiente = nodoActual;
            //conectamos el nodo de segunda posicion con el comienzo
            nodoActual.Anterior = nodoInicial;

            //eliminamos conexiones del primer nodo
            nodoExtra.Siguiente = null;
            nodoExtra.Anterior = null;
            //reconectamos nodo final con el nuevo primer nodo
            nodoFinal.Final = nodoActual;


        }


    }

}
