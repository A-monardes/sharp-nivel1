namespace _4articulos;

class Program
{
    static void Main(string[] args)
    {
        // Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
        //- Número de Artículo (1 a 15)
        //- Cantidad Vendida 
        //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
        //Se pide determinar e informar:
        //a) El número de artículo que más se vendió en total.
        //b) Los números de artículos que no registraron ventas.
        //c) Cuantas unidades se vendieron del número de artículo 10.

        int[] vVen = new int[15];
        int nArt, cVen, max, maxNum;

        for (var x = 0; x < 15; x++){
            vVen[x] = 0;
        }

        Console.WriteLine("Ingrese un número de articulo (1 al 15):");
        nArt = int.Parse(Console.ReadLine());

        while(nArt!=0 && nArt<=15 && nArt>=1){
            Console.WriteLine("Y cuantas cantidades se vendieron del mismo:");
            cVen = int.Parse(Console.ReadLine());

            vVen[nArt-1] += cVen;

            Console.WriteLine("Para continuar, ingrese un número de articulo (1 al 15) o cero para dejar de cargar:");
            nArt = int.Parse(Console.ReadLine());
        }

        max = vVen[0];
        maxNum = 1;

        for (int x = 0; x < 15; x++){
            if(vVen[x] > max){
                max=vVen[x];
                maxNum=x+1;
            }
        }

        Console.WriteLine("El articulo que mas se vendio es el articulo número " + maxNum + " con " + max + " unidades");

        for (var x = 0; x < 15; x++){
            if(vVen[x] == 0){
                Console.Write("Articulo número " + x+1 + " no tuvo ventas");
            }
        }
        
        Console.WriteLine("El articulo número 10 vendio " + vVen[9] + " articulos");

    }
}
