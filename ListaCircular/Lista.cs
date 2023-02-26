using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircular
{
    internal class Lista
    {
        //este es el ancla o encabezado de la lista
        private Nodo ancla;
        //esta variable de referencia nos ayuda a trabajar con la lista
        private Nodo trabajo;//indica con que nodo se esta trabajando
        //esta variable de referencia apoya en ciertas operaciones de la lista
        private Nodo trabajo2;//para busquedas y saber cual es el nodo anterior(por ejemplo)

        public Lista()
        {
            //instanciamos ancla
            ancla = new Nodo();
            //como es una lista vacia su siguiente es null
            ancla.Siguiente = null;
        }

        //recorrer toda la lista
        public void Recorrer()
        {
            //trabajo al inicio
            trabajo = ancla;
            //recorremos hasta encontrar el final
            while(trabajo.Siguiente != null)
            {
                //avanzamos trabajo
                trabajo = trabajo.Siguiente;
                //obtenemos el dato y lo mostramos
                int d = trabajo.Dato;
                Console.Write("{0}, ",d);
            }
            //bajamos linea
            Console.WriteLine();
        }

        //agregar nodo
        public void Agregar(int pDato)
        {
            //trabajo al inicio
            trabajo = ancla;
            //recorrer hasta llegar al final
            while( trabajo.Siguiente != null)
            {
                //avanzamos trabajo
                trabajo = trabajo.Siguiente;
            }
            //creamos el nuevo nodo
            Nodo temp = new Nodo();
            //incertamos el dato
            temp.Dato = pDato;
            //definimos su salida
            temp.Siguiente = null;
            //ligamos el ultimo nodo encontrado con el recien creado
            trabajo.Siguiente = temp;
        }

        //vaciar la lista
        public void Vaciar()
        {
            ancla.Siguiente = null;//se aprovecha el recolector de basura y los elemento se eliminan
        }

        //indica si la lista esta vacia o no
        public bool EstaVacio()
        {
            if (ancla.Siguiente == null)
                return true;
            else
                return false;
        }

        //regresar el nodo con la primera ocurrencia del dato -> primero en encontrar
        public Nodo Buscar(int pDato)
        {
            if (EstaVacio() == true)
                return null;
            trabajo2 = ancla;
            //recorremos para ver si lo encontramos
            while (trabajo2.Siguiente != null)
            {
                trabajo2 = trabajo2.Siguiente;
                //al encontrarlo, lo regresamos
                if(trabajo2.Dato == pDato)
                    return trabajo2;
            }
            //si no se encuentra, regresamos null
            return null;
        }
    }
}
