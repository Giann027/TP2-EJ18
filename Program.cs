using System;

namespace TP2_EJ18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BUENASSS!");
            Console.Title = " Transformar de grados sexagesimales a radianes, exigiendo valor positivo";

            double constante, sexagesimales, radianes;

            Console.Write("Ingrese el valor sexagesimal: ");
            sexagesimales = Convert.ToSingle(Console.ReadLine());

            constante = 0.0174532925;
            radianes = sexagesimales * constante;

            if (sexagesimales >= 0)

                Console.Write($"el valor en radianes es {radianes}");

            else

                Console.Write($"Error, por favor ingrese un valor mayor que cero ");
        }
    }
}
