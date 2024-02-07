namespace _4menor;

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
        int n1, n2, n3, n4;
        int menor;

        Console.WriteLine("Introduzca los 4 números:");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());

        menor = n1;

        if(n2<menor){
            menor=n2;
        }
        if(n3<menor){
            menor=n3;
        }
        if(n4<menor){
            menor=n4;
        }

        Console.WriteLine("El número menor es " + menor);
    }
}
