internal class Program
{
    private static void Main(string[] args)
    {
        //Inicio
        Console.WriteLine("Colocar del 1 al 12 para decirle cual mes es: ");
        int NM = int.Parse(Console.ReadLine());
        //Proceso, Salida y Evaluar
        if (NM == 1) {
            Console.WriteLine("El Mes es Enero");
        } 
        else if (NM == 2)
        {
            Console.WriteLine("El Mes es Febrero");
        } 
        else if (NM == 3)
        {
            Console.WriteLine("El Mes es Marzo");
        } 
        else if (NM == 4)
        {
            Console.WriteLine("El Mes es Abril");
        }
        else if (NM == 5)
        {
            Console.WriteLine("El Mes es Mayo");
        }
        else if (NM == 6)
        {
            Console.WriteLine("El Mes es Junio");
        }
        else if (NM == 7)
        {
            Console.WriteLine("El Mes es Julio");
        }
        else if (NM == 8)
        {
            Console.WriteLine("El Mes es Agosto");
        }
        else if (NM == 9)
        {
            Console.WriteLine("El Mes es Septiembre");
        }
        else if (NM == 10)
        {
            Console.WriteLine("El Mes es Octubre");
        }
        else if (NM == 11)
        {
            Console.WriteLine("El Mes es Noviembre");
        }
        else if (NM == 12)
        {
            Console.WriteLine("El Mes es Diciembre");
        } else
        {
            Console.WriteLine("El Numero no es parte de los meses");
        }
    }
}