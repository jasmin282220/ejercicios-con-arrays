using System;
using System.Collections.Generic;

namespace media_aritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para ingresar 5 numeros y determinar la media de estos");
            int i = 0, j = 1;
            float[] numeros = new float[5];

            do
            {
                Console.WriteLine("ingrese el numero de la posicion #{0}:", j);
                j++;
                numeros[i] = float.Parse(Console.ReadLine());
                ++i;
            }
            while (i < 5);

            Array.Reverse(numeros);

            Console.WriteLine("El valor de los numeros digitados al reves es :");

            foreach (float a in numeros)

            {
                Console.Write(" #" + a);

            }

        }
    }
}


