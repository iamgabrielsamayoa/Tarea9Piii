using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9PIII.Clases
{
    class NodoLE
    {
        public Object elemento;
        public NodoLE siguiente;


        public NodoLE(Object entrada)
        {
            this.elemento = entrada;
            this.siguiente = null;

        }
    }
}
