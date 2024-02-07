using System;

namespace TPFinal_MonardesCasas
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());

           Console.WriteLine("El resultado es: " + algo2(ref a, ref b));
           Console.WriteLine("El resultado es: " + algo2(ref a, ref b));
           Console.WriteLine("El resultado es: " + algo2(ref a, ref a));
        }

        static int algo2(ref int num, ref int num2){

        int res;
        num = num * 2;
        num2 = num2 * 3;

        res = num * num2;

        return res;
        }


    }
}
