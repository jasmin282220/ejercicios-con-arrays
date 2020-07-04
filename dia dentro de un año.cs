using System;

namespace dia_dentro_del_año
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;int d = 0;int m = 0;int suma = -16;
            int[] mes ={31,28,31,30,31,30,31,31,30,31,30,31
};



                Console.WriteLine("\n\n Ingrese un numero para indicarte un mes");
            m = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < m; ++i)
                suma += mes[i];
            Console.WriteLine("Ingrese un dia");
            d = Convert.ToInt32(Console.ReadLine());
            suma += d;
            Console.WriteLine("El numero de dia dentro del año es: {0}", suma);
            Console.Read();
            Console.ReadKey();




            }
}
}
