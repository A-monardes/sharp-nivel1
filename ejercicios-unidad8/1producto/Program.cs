namespace _1producto;

class Program
{
    static void Main(string[] args)
    {
        //Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

        int precio, articulo, resultado;

        Console.WriteLine("Ingrese el precio del articulo comprado:");
        precio = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de artículos comprados:");
        articulo = int.Parse(Console.ReadLine());

        resultado = producto(precio, articulo);

        Console.WriteLine("El precio a pagar es $" + resultado);
    }

    static int producto(int a, int b){
        int r = a*b;
        return r;
    }
}
