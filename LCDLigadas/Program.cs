using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCDLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lista list = new Lista();


            //agregamos elementos
            list.Agregar("Primero");
            list.Agregar("Segundo");
            list.Agregar("Tercero");

            //probamos recorrer
            Console.WriteLine(list.Recorrer());


            //buscamos un valor y mostramos su posicion en la lista de nodos
            Console.WriteLine(list.Buscar("Segundo"));
            Console.ReadKey();

            //agregamos al inicio
            list.AgregarInicio("Nuevo primero");
            Console.WriteLine(list.Recorrer());



            //borrar el ultimo de la lista
            list.Borrar();
            Console.WriteLine(list.Recorrer());

            //borrar el primero
            list.BorrarInicio();
            Console.WriteLine(list.Recorrer());

            Console.ReadKey();


        }

    }
}
