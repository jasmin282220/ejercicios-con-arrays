using System;

namespace media_por_encima
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int jml,media,desvio;int acumld = 0;
           

            for(jml=0;jml <10;jml++)
            {
                Console.WriteLine("Ingrese un numero \n");
                numeros[jml] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-", numeros[jml]);
                acumld += numeros[jml];
            }

            media = acumld / 10;
            Console.WriteLine("La media de los numeros ingresados es: " + media);

            for (jml = 0; jml < 10; jml++)
            {
                desvio = (numeros[jml] - media);
                if (desvio > 0)
                    Console.WriteLine(" Los numeros por encima de la media son:"+ numeros[jml]);

            }
            Console.Read();
            Console.ReadKey();
        }
    }
}