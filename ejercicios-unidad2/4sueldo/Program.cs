using System;

namespace _4sueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

            float facturado, total, comision;
            const float sueldo = 15000;
            const float porcentaje = 0.05F;

            Console.WriteLine("Cuanto facturo el empleado?");
            facturado = float.Parse(Console.ReadLine());

            //regla 3 simples: (5 * facturado) / 100
            //otra opcion: facturado / 20


            comision = facturado * porcentaje;
            total = comision + sueldo;
            Console.WriteLine("El total que va a cobrar es " + total);
        }
    }
}
