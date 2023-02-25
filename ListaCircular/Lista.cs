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
    }
}
