using System;

namespace _3kilometro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

            float km, velocidad, resultado, minutos, total;

            Console.WriteLine("A cuantos kilometros esta la ciudad?");
            km = int.Parse(Console.ReadLine());
            Console.WriteLine("A cuantos kilometros por hora viaja el auto?");
            velocidad = int.Parse(Console.ReadLine());

            resultado = km/velocidad;

            total = resultado * 60;
            minutos = total % 60;

            Console.WriteLine("Vas a llegar a la ciudad en " + resultado.ToString("0") + " horas y " + minutos.ToString("0") + " minutos");
        }
    }
}
