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

        //Buscar el indice donde se encuentra la primera ocurrencia del dato
        public int BuscarIndice(int pDato)
        {
            int n = -1;
            trabajo = ancla;
            while(trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                n++;
                if(trabajo.Dato == pDato)
                    return n;
            }
            return -1;
        }

        //encuentra el nodo anterior, si esta al comienzo regresa ancla, si no existe, regresa el ultimo nodo
        public Nodo BuscarAnterior(int pDato)
        {
            trabajo2 = ancla;
            while (trabajo2.Siguiente !=null && trabajo2.Siguiente.Dato != pDato)
            {
                trabajo2 = trabajo2.Siguiente;

            }
            return trabajo2;
        }

        //Borrar la primera ocurrencia del dato
        public void Borrar(int pDato)
        {
            //se verifica que tenga datos
            if (EstaVacio() == true)
                return;

            //buscamos los nodos con los que trabajaremos
            Nodo anterior = BuscarAnterior(pDato);
            Nodo encontrado = Buscar(pDato);
            //si no hay nodo a borrar, salimos
            if (encontrado == null)
                return;

            //buscamos el nodo
            anterior.Siguiente = encontrado.Siguiente;

            //quitamos el actual de la lista
            encontrado.Siguiente = null;
        }

        //busca un dato e insertar otro enfrente de el
        public void Insertar(int pDonde, int pValor)
        {
            //encontramos la posicion donde vamos a insertar
            trabajo = Buscar(pDonde);

            //verificamos que exista donde vamos a insertar
            if (trabajo == null)
                return;

            //creamos el nodo temporal a insertar
            Nodo temp = new Nodo();
            temp.Dato = pValor;
            //conectamos el temporal a la lista
            temp.Siguiente = trabajo.Siguiente;
            //conectamos trabajo a temporal
            trabajo.Siguiente = temp;
        }

        //insertar al inicio
        public void InsertarInicio(int pDato)
        {
            //creamos el nodo temporal
            Nodo temp = new Nodo();
            temp.Dato = pDato;

            //conectamos el temporal a la lista
            temp.Siguiente = ancla.Siguiente;

            //conectamos el ancla al temporal
            ancla.Siguiente = temp;
        }

        //dar el valor del nodo al ingresar su posicion en el indice
        public Nodo ObtenerPorIndice(int pIndice)
        {
            Nodo trabajo2 = null;
            int indice = -1;

            while(trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                indice++;
                if (indice == pIndice)
                    trabajo2 = trabajo;

            }
            return trabajo2;
        }
    }
}
