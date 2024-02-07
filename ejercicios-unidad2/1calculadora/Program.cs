using System.Reflection.Emit;
using System.Data;
using Internal;
using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variables y tipo de dato: int (entero), float (decimal), char(letra), bool(verdadero o falso)

            int n1, n2, resultado;

            //pedir valores

            Console.WriteLine("Ingrese un numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero:");
            n2 = int.Parse(Console.ReadLine());
            
            //realizar calculo

            resultado = n1 + n2;

            //emitir resultado

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
