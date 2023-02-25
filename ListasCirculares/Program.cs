using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nodo nodo = new Nodo();
            Lista list = new Lista();


            //agregamos elementos
            list.Agregar("Primero");
            list.Agregar("Segundo");
            list.Agregar("Tercero");

            //probamos recorrer
            Console.WriteLine(list.Recorrer());
            Console.ReadKey();

            //buscamos un valor y mostramos su posicion
            Console.WriteLine(list.Buscar("Primero"));
            Console.ReadKey();

            //agregamos al inicio
            list.AgregarInicio("Nuevo primero");
            Console.WriteLine(list.Recorrer());
            Console.ReadKey();

        }
    }

}
