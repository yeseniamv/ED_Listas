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
        }
    }
}
