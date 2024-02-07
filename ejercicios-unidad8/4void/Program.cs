namespace _4void;

class Program
{
    static void Main(string[] args)
    {
        //Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:
        //a. 1 si el número es positivo.
        //b. -1 si el número es negativo.
        //c. 0 si el número es cero.

        int n, var = 0;

        Console.WriteLine("Ingrese un número:");
        n = int.Parse(Console.ReadLine());

        positivoNegativoCero(n, ref var);

        if(var==1){
            Console.WriteLine("El número es positivo");
        }else if(var==-1){
            Console.WriteLine("El número es negativo");
        }else if(var==0){
            Console.WriteLine("El número es cero");
        }
    }

    static void positivoNegativoCero (int n, ref int var){
        if(n>0){
            var = 1;
        }else if(n<0){
            var = -1;
        }else{
            var = 0;
        }
    }
}
