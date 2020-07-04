using System;

namespace dias_de_semana
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] Dsemana = new string[7];

            Dsemana[0] = "lunes";
            Dsemana[1] = "Martes";
            Dsemana[2] = "Miercoles";
            Dsemana[3] = "Jueves";
            Dsemana[4] = "Viernes";
            Dsemana[5] = "Sabado";
            Dsemana[6] = "Domingo";
            Console.WriteLine("Los dias de semana son:");

       foreach (var dia in Dsemana)
            {
                Console.WriteLine(dia);

            }
    }
}
}