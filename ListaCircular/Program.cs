using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista miLista = new Lista();
            miLista.Agregar(1);
            miLista.Agregar(2);
            miLista.Agregar(3);
            miLista.Agregar(4);
            miLista.Agregar(5);

            //activar el metodo para recorrer
            miLista.Recorrer();
            Console.ReadKey();

            //metodo para vaciar lista
            miLista.Vaciar();
            //valida si esta vacia la lista
            Console.WriteLine(miLista.EstaVacio());

            //se vuelven a agregar elementos
            miLista.Agregar(6);
            miLista.Agregar(7);
            miLista.Agregar(8);
            miLista.Agregar(9);
            miLista.Agregar(10);

            //activar el metodo para recorrer
            miLista.Recorrer();

            Console.ReadKey();

            //activar metodo de busqueda
            Nodo encontrado = miLista.Buscar(7);
            Console.WriteLine(encontrado);
            Console.ReadKey();

            //busqueda de indice
            Console.WriteLine(miLista.Buscar(9));
            Console.ReadKey();

            //borrar dato
            miLista.Borrar(10);
            Console.ReadKey();

            //insertar dato despues de otro ya existente
            miLista.Insertar(7, 20);
            Console.ReadKey();

            //insertar elemento al inicio
            miLista.InsertarInicio(13);
            Console.ReadKey();

            //obtiene un valor dando una posicion en el indice
            Console.WriteLine(miLista.ObtenerPorIndice(4));
            Console.ReadKey();
        }
    }
}
