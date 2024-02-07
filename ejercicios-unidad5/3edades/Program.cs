namespace _3edades;

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

        int edad, con = 0, promedio = 0;

        Console.WriteLine("Ingrese las veinte edades");
        for (int x = 0; x < 20; x++){
            edad = int.Parse(Console.ReadLine());

            if(edad>18){
                promedio += edad;
                con++;
            }
        }
        promedio = promedio / con;

        Console.WriteLine("El promedio de las edades mayores a 18 es " + promedio);

    }
}
