using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDLigadas
{
    internal class Nodo
    {
        public string Valor { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo Anterior { get; set; }

        public Nodo(string valor ="", Nodo anterior = null, Nodo siguiente = null)
        {
            Valor = valor;
            Siguiente = anterior;
            Anterior = siguiente;
        }
    }
}
