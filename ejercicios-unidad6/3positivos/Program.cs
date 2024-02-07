namespace _3positivos;

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

        int n = 1, con = 0, conl = 0;

        while(n>=0){
            conl++;
            con = 0;

            Console.WriteLine("Ingrese un número mayor a cero para comenzar con una lista:");
            n = int.Parse(Console.ReadLine());

            while(n > 0){
            con++;
            Console.WriteLine("Ingrese otro numero, cero para terminar la lista o un numero negativo para terminar la carga");
            n = int.Parse(Console.ReadLine());
            }
        if(con>0){
        Console.WriteLine("La lista " + conl + " tiene " + con + " números.");
        }
        }

    }
}
