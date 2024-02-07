namespace _5mayor;

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
    
        int n1, n2, n3, n4; 
        int con = 0;

        Console.WriteLine("Ingrese los 4 números:");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());

        Console.WriteLine("Los mayores a 100 son:");
        if(n1 > 100) {
           Console.Write(n1 + " ");
           con++;
        }
        if(n2 > 100) {
            Console.Write(n2 + " ");
            con++;
        }
        if(n3 > 100) {
            Console.Write(n3 + " ");
            con++;
        }
        if(n4 > 100) {
            Console.Write(n4);
            con++;
        }

        if(con>0){
            Console.Write(" son mayores a 100");
        }
    }
}
