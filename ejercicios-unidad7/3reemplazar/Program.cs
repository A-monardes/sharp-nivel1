namespace _3reemplazar;

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
        //CADENA FUENTE: “La mar estaba serena"
        // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        //CADENA RESULTADO: “Li mir estibi sereni"

        char[] frase = new char[50];
        int indice = 0;
        char letra, letra1, letra2;

        Console.WriteLine("Escriba la frase letra por letra:");
        letra = char.Parse(Console.ReadLine());

        while(letra!='.' && indice<50){
            frase[indice] = letra;
            indice++;
            letra = char.Parse(Console.ReadLine());
        }

        Console.Write("La frase es: ");
        indice = 0;
        while(frase[indice]!='\0'){
            Console.Write(frase[indice]);
            indice++;
        }

        Console.WriteLine("       Ahora indique la letra que quiere reemplazar: ");
        letra1 = char.Parse(Console.ReadLine());
        Console.WriteLine("Y la letra por la que lo quiere reemplazar: ");
        letra2 = char.Parse(Console.ReadLine());

        indice=0;
        while(frase[indice]!='\0' && indice<50){
            if(frase[indice]== letra1){
                frase[indice] = letra2;
            }
            indice++;
        }

        Console.WriteLine("La frase reemplazando '" + letra1 + "' por '" + letra2 + "' es:");

        indice = 0;
        while(frase[indice]!='\0'){
            Console.Write(frase[indice]);
            indice++;
        }
    }
}
