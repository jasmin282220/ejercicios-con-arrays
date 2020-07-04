using System;

namespace dias_del_mes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un programa que almacene en una tabla el número de días que tiene 
            //cada mes (supondremos que es un año no bisiesto), pida al usuario que le indique un mes 
            //(1=enero, 12=diciembre) y muestre en pantalla el número de días que tiene ese mes.


            int[] Dias = new int[4];
            Dias[1] = 28;
            Dias[2] = 31;
            Dias[3] = 30;
            int mes;
           


                Console.WriteLine("Presione un numero para indicarte un mes:");
            mes = Convert.ToInt32(Console.ReadLine());

            if (mes > 0 && mes <=12)
            {
                if (mes == 1)
                    Console.WriteLine( "Enero tiene {0} dias", Dias[3]);
                if (mes == 2)
                    Console.WriteLine( "Febrero tiene:", Dias[1]);
                if (mes == 3)
                    Console.WriteLine( "Marzo tiene {0} dias", Dias[2]);
                if (mes == 4)
                    Console.WriteLine( "Abril tiene {0} dias", Dias[3]);
               else if (mes == 5)
                    Console.WriteLine( "Mayo tiene {0} dias", Dias[2]);
                if (mes == 6)
                    Console.WriteLine("Junio tiene {0} dias", Dias[3]);
                if (mes == 7)
                    Console.WriteLine( "-Julio tiene {0} dias", Dias[2]);
                if (mes == 8)
                    Console.WriteLine( "agosto tiene {0} dias", Dias[2]);
                if (mes == 9)
                    Console.WriteLine("septiembre tiene {0} dias", Dias[3]);
                if (mes == 10)
                    Console.WriteLine( "Octubre tiene {0} dias", Dias[2]);
                if (mes == 11)
                    Console.WriteLine("Noviembre tiene {0} dias", Dias[3]);
                if (mes == 12)
                    Console.WriteLine("Diciembre tiene {0} dias", Dias[2]);
            }

            else
            {
                Console.WriteLine("Error un año solo tiene 12 meses :(");
              

                Console.ReadLine();




        }
    }
    }
    }



