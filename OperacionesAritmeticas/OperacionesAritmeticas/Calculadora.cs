using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    public class Calculadora
    {

        public decimal N1;
        public decimal N2;

        public static decimal suma(decimal N1, decimal N2)
        { return N1 + N2; }

        public static decimal resta(decimal N1, decimal N2)
        {return N1 - N2;}

        public static decimal multiplicacion(decimal N1, decimal N2)
        {return N1 * N2;}

        public static decimal division(decimal N1, decimal N2)
        {return N1 / N2;}

        public static decimal modulo(decimal N1, decimal N2)
        {return N1 % N2;}



        public static decimal? Operacion(OperacionAritmetica operacionAritmetica)
        {
            decimal? re;
            if (operacionAritmetica.TYP == tipoOperacion.sumar)
            {
                re = suma(operacionAritmetica.N1, operacionAritmetica.N2);
                Console.WriteLine("La suma es: "+re);
                Console.ReadKey();
            }
            else if (operacionAritmetica.TYP == tipoOperacion.resta)
            {
                re = resta(operacionAritmetica.N1, operacionAritmetica.N2);
                Console.WriteLine("La resta es: " + re);
                Console.ReadKey();
            }
            else if (operacionAritmetica.TYP == tipoOperacion.multiplicacion)
            {
                re = multiplicacion(operacionAritmetica.N1, operacionAritmetica.N2);
                Console.WriteLine("La multi es: " + re);
                Console.ReadKey();
            }
            else if (operacionAritmetica.TYP == tipoOperacion.division)
            {
                re = division(operacionAritmetica.N1, operacionAritmetica.N2);
                Console.WriteLine("La divi es: " + re);
                Console.ReadKey();
            }
            else if (operacionAritmetica.TYP == tipoOperacion.modulo)
            {
                re = modulo(operacionAritmetica.N1, operacionAritmetica.N2);
                Console.WriteLine("El modulo es: " + re);
                Console.ReadKey();
            }
            else
            
                re = null;
                return re;
               

        }



        public static Resultado Simultaneas(decimal N1, decimal N2)
        {

            Console.WriteLine("Simultaneas");

            Resultado re = new Resultado();

            re.S = suma(N1, N2);
            Console.WriteLine("SUMA: "+re.S);
            re.R = resta(N1, N2);
            Console.WriteLine("RESTA: "+re.R);
            re.M = multiplicacion(N1, N2);
            Console.WriteLine("MULTI: "+re.M);
            re.D = division(N1, N2);
            Console.WriteLine("DIVI: "+re.D);
            re.O = modulo(N1, N2);
            Console.WriteLine("MOD: " + re.O);

    
            Console.ReadKey();
            return re;
        }



        public static void Presentacion()
        {


            Console.WriteLine("Operacion a realizar");
            Console.WriteLine("0.-Sumar");
            Console.WriteLine("1.-Restar");
            Console.WriteLine("2.-Multiplicar");
            Console.WriteLine("3.-Dividir");
            Console.WriteLine("4.-Modulo");
            Console.WriteLine("5.-Todas");



            Console.WriteLine("Selecciona Operación a realizar");
            int ope = int.Parse(Console.ReadLine());

            Console.WriteLine("NUMERO 1");
            decimal n1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("NUMERO 2");
            decimal n2 = decimal.Parse(Console.ReadLine());

            OperacionAritmetica ops = new OperacionAritmetica();
            ops.TYP = (tipoOperacion)ope;
            ops.N1 = n1;
            ops.N2 = n2;

            if (ope <= 4) {

                decimal? fi = Operacion(ops);
                Console.WriteLine(fi);

            } else if (ope == 5){
                Resultado RE = new Resultado();
                RE = Simultaneas(n1, n2);
                Console.WriteLine(RE.S);

            }
            else {
                Console.WriteLine("No krnaaaal");
                Console.ReadKey();
            }


        }

    }
}



