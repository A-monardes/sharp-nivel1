namespace _5parimpar;

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

        int n, maxp = 0, maxi = 0, bp = 0, bi = 0;

        Console.WriteLine("Ingrese los 20 números");

        for (int x = 0; x < 20; x++){
            n = int.Parse(Console.ReadLine());

            if(n%2 == 0){
                if(bp == 0){
                    maxp = n;
                    bp++;
                }else if (n > maxp){
                    maxp = n;
                }
            }else{
                if(bi == 0){
                    maxi = n;
                    bi++;
                } else if (n > maxi){
                    maxi = n;
                }
            }
        }

        Console.WriteLine("El mayor de los pares es " + maxp + " y el menor de los impares es " + maxi);

    }
}
