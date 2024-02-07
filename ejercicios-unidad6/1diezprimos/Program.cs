namespace _1diezprimos;

class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

        int n, con = 0, conp = 0;

        Console.WriteLine("Ingrese los 10 números");
        for (var x = 0; x < 10; x++){
            n = int.Parse(Console.ReadLine());
            
            con=0;
            for(int y = 1; y <= n; y++){
                if(n%y==0){
                    con++;
                }
            }
            if(con==2){
                conp++;
            }
        }
        Console.WriteLine(conp + " de los números ingresados son primos.");

    }
}
