namespace _3computacion;

class Program
{
    static void Main(string[] args)
    {
        //Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:
	                //i5 (1) 	i7 (2) 	    i9 (3)
    //8 RAM (1) 	USD 800 	USD 900 	USD 1200
    //16 RAM (2) 	USD 900 	USD 1000 	USD 1400
    //32 RAM (3) 	USD 1000 	USD 1400 	USD 2000

    //Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. 
    //Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.

    int procesador, ram, disco, total = 0;

    Console.WriteLine("Ingrese el procesador que desee:");
    Console.WriteLine("1- i5");
    Console.WriteLine("2- i7");
    Console.WriteLine("3- i9");

    procesador = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la memoria RAM que desee:");
    Console.WriteLine("1- 8 RAM");
    Console.WriteLine("2- 16 RAM");
    Console.WriteLine("3- 32 RAM");
    
    ram = int.Parse(Console.ReadLine());

    Console.WriteLine("Quiere extender el disco?");
    Console.Write("1- Si");
    Console.Write("   2- No");

    disco = int.Parse(Console.ReadLine());

    if (procesador==1){
        if (ram==1){
            total = 800;
        }else if(ram==2){
            total = 900;
        } else {
            total = 1000;
        }
    }

    if (procesador==2){
        if (ram==1){
            total = 900;
        }else if(ram==2){
            total = 1000;
        } else {
            total = 1400;
        }
    }

    if (procesador==3){
        if (ram==1){
            total = 1200;
        }else if(ram==2){
            total = 1400;
        } else {
            total = 2000;
        }
    }

    if (disco==1) {
        total+= 300;
    }
        Console.WriteLine("El total a pagar es de " + total + "U$D");
    }
}