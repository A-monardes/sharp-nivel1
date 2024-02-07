namespace _3primo;

class Program
{
    static void Main(string[] args)
    {
        //Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

        int n, p, conp = 0, acu =0, prom;

        Console.WriteLine("Ingrese un número:");
        n = int.Parse(Console.ReadLine());

        while(n!=0){
            p = primo(n);

            if(p==1){
                acu += n;
                conp++;
            }

            Console.WriteLine("Ingrese otro número o cero para terminar:");
            n = int.Parse(Console.ReadLine());
        }
        prom = acu / conp;

        Console.WriteLine("Se ingresaron " + conp + " números primos y el promedio de estos es de " + prom);
    }

    static int primo (int a){
        int con = 0;
        for (var x = 1; x <= a; x++){
            if(a%x==0){
                con++;
            }
        }
            if (con==2){
                return 1;
            }else{
                return 0;
            }
    }
}
