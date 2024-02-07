namespace _2cincolistas;

class Program
{
    static void Main(string[] args)
    {
        //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar: El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo. Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

        int n, grupoMaximo = 0, grupoOrdenado = 5, conImpares = 0, contNumeros = 0, nactual = 0;
        bool b = false;
        double PorcentajeImpares = 0, PorcentajeMaximo = -1;


        for (int x = 0; x < 5; x++){           
        Console.WriteLine("Introduzca un número:");
        n = int.Parse(Console.ReadLine());

        contNumeros=0;
        conImpares=0;
        b=false;

            while(n!=0){
                contNumeros++;
                nactual = n;

                if(n%2!=0){
                    conImpares++;
                }

            Console.WriteLine("Introduzca un número para continuar o cero para pasar a la sigueinte lista:");
            n = int.Parse(Console.ReadLine());

                if(n>=nactual && b==false && n!=0){
                    grupoOrdenado--;
                    b=true;
                }
            }

            PorcentajeImpares = (conImpares*100)/contNumeros;

            if(x==0){
                grupoMaximo = 1;
                PorcentajeMaximo = PorcentajeImpares;
            }else if(PorcentajeImpares > PorcentajeMaximo){
                grupoMaximo = x + 1;
            }
            
            Console.WriteLine("Grupo " + (x+1) + " tiene un " + PorcentajeImpares + "% de números impares");
        }

        Console.WriteLine("El grupo con mayor porcentaje de números impares es el grupo " + grupoMaximo);
        Console.WriteLine(grupoOrdenado + " de las listas están ordenados de meyor a menor");
    }
}