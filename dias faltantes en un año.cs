using System;

namespace numeros_de_dias_hasta_fin_de_año
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; int d = 0; int m = 0; int suma = -16;
            int[] mes ={31,28,31,30,31,30,31,31,30,31,30,31
};



            Console.WriteLine("\n\n Ingrese un numero para indicarte un mes");
            m = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <(m-1); ++i)
                suma += mes[i];
            Console.WriteLine("Ingrese un dia");
            d = Convert.ToInt32(Console.ReadLine());
            suma += d;
            Console.WriteLine("Faltan: {0} dias para que finalice el año ",365- suma);
            Console.Read();
            Console.ReadKey();
        }
    }
}
