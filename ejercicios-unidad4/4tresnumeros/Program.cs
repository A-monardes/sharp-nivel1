namespace _4tresnumeros;

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

        int n1, n2, n3;

        Console.WriteLine("Ingrese los tres números:");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());

        if ((n1+n2)>(n2*n3)){
            Console.WriteLine("La suma del primero con el segundo es más grande que el producto del segundo con el tercero");
        }
    }
}
