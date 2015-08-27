using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMKids
{
    class metodos
    {


        public bool disponible = true;
        public double altura = 0, anchura = 0;
        public string nombre = "";
        public metodos(bool d, double a, double b, string n)
        {
            nombre = n;
            disponible = d;
            anchura = b;
            altura = a;
        }



    }
}
