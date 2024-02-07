namespace _2diezpromedio;

class Program
{
    static void Main(string[] args)
    {
         //Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

         int[] numeros = new int[10];
         int acu = 0, promedio, con = 0;
         Console.WriteLine("Ingrese los 10 números:");

         for (var x = 0; x < 10; x++){
            numeros[x] = int.Parse(Console.ReadLine());
            acu+=numeros[x];
         }

        promedio = acu/10;

        Console.WriteLine("El promedio es " + promedio);

        for (var x = 0; x < 10; x++){
            if(numeros[x] > promedio){
                Console.WriteLine(numeros[x]);
                con++;
            }
        }
        if(con>0){
        Console.WriteLine("son mayores al promedio");
        }

    }
}
