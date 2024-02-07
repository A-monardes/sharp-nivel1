using System;

namespace _5nota
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.

            float n1, n2, n3, total;

            Console.WriteLine("Ingrese la primer nota:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota:");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota:");
            n3 = float.Parse(Console.ReadLine());

            total = (n1+n2+n3)/3;

            Console.WriteLine("El promedio final es " + total.ToString("0.0"));
        }
    }
}
