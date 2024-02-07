namespace _1dieznumeros;

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

        int [] numeros = new int [10];
        int max, pos;

        Console.WriteLine("Ingrese los 10 números:");
        for (var x = 0; x < 10; x++){
            numeros[x] = int.Parse(Console.ReadLine());
        }
        max = numeros[0];
        pos = 1;

        for (var x = 1; x < 10; x++){
            if (numeros[x] > max){
                max = numeros[x];
                pos = x+1;
            }
        }

        Console.WriteLine(max + " es el número más grande y fue ingresado en la posición " + pos);

    }
}
