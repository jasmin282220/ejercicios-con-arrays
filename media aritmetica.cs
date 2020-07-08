using System;
using System.Collections.Generic;

namespace media_de_4
{
    class Program
    {
        static void Main(string[] args)
        {
            

                int num, num1, num2, num3;
                int mediaArit;


                Console.WriteLine("Ingrese el primer numero");
                num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el tercer numero");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el cuarto numero");
                num3 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                mediaArit = num + num1 + num2 + num3 / 4;

                Console.WriteLine("La media de los numeros es:" + mediaArit);
                Console.WriteLine("\n los numeros ingresados son:");

            List<int> numeros = new List<int>();


                numeros.Add(num);
                numeros.Add(num1);
                numeros.Add(num2);
                numeros.Add(num3);
        
                foreach (int number in numeros)
                    Console.WriteLine(number);


                Console.WriteLine("presione cualquier tecla para cerrar el programa");

            }

        }
}