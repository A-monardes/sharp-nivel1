namespace _2par;

class Program
{
    static void Main(string[] args)
    {
        //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

        int n, con= 0;

        Console.WriteLine("Ingrese los 20 números");

        for (var x = 0; x < 20; x++){
            n = int.Parse(Console.ReadLine());

            bool p = par(n);

            if(p){
                con++;
            }
        }
        Console.WriteLine(con + " de los números ingresados son pares");
    }

    static bool par(int a){
        if(a%2 == 0){
            return true;
        }else{
            return false;
        }
    }
}
