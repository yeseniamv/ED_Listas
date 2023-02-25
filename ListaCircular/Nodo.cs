using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircular
{
    internal class Nodo
    {
        
        //datos a guardar en el nodo
        private int dato;
        //Variable de referencia para apuntar al nodo siguiente
        private Nodo siguiente = null;
        //propiedades que usaremos
        public int Dato { get => dato; set => dato = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
        //para su facil impresion
        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }

    }
}
