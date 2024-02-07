namespace _4primo;

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

        int n, con = 0;

        Console.WriteLine("Ingrese un número");
        n = int.Parse(Console.ReadLine());

        for (int x = 1; x <= n; x++){
            if(n%x==0){
                con++;
            }
        }
        if(con==2){
            Console.WriteLine(n + " es primo");
        }else{
            Console.WriteLine(n + " no es primo");
        }

    //Otra opcion omitiendo el terner que dividir por 1 y por si mismo
    for (int x=2; x<n; x++){
        if(n%==0){
            con++;
        }
    }
    if(con==0){
            Console.WriteLine(n + " es primo");
    }else{
            Console.WriteLine(n + " no es primo");
    }

    }
}
