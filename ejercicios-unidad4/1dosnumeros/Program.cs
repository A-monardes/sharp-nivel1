namespace _1dosnumeros;

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa que solicite el ingreso de dos números y luego calcular:

        //La resta si el primero es mayor que el segundo.
        //La suma si son iguales.
        //El producto si el primero es menor.

        //Se deberá emitir un cartel por pantalla con el resultado correspondiente.

        int n1, n2, resultado;

        Console.WriteLine("Ingrese los dos números:");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        if(n1>n2){
            resultado = n1-n2;
            Console.WriteLine("Se realizo una resta");
        } else if (n1==n2) {
            resultado = n1+n2;
            Console.WriteLine("Se realizo una suma");
        } else {
            resultado = n1*n2;
            Console.WriteLine("Se realizo una multiplicación");
        }

        Console.WriteLine("El resultado es " + resultado);
    }
}
