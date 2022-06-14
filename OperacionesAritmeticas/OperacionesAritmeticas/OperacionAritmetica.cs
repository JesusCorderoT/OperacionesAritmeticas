using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    public struct OperacionAritmetica
    {
        public  OperacionAritmetica(decimal n1 ,decimal n2, tipoOperacion typ) { 
            N1 = n1;
            N2 = n2;
            TYP = typ;
        }

        public decimal N1 { get; set; }
        public decimal N2 { get; set; }
        public tipoOperacion TYP { get; set; }
    }
}
