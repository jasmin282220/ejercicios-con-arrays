using System;
using System.Collections.Generic;

namespace array_float
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int i = 0, m = 1;
            float[] numeros = new float[5];

            do
            {
                Console.WriteLine("ingrese el numero de la posicion #{0}:", m);
                m++;
                numeros[i] = float.Parse(Console.ReadLine());
                ++i;
            }
            while (i < 5);

            Array.Reverse(numeros);

            Console.WriteLine("Los numeros ingresados al contrario  son :");

            foreach (float numeritos in numeros)

            {
                Console.Write("/" + numeritos);

            }

        }
    }
}

