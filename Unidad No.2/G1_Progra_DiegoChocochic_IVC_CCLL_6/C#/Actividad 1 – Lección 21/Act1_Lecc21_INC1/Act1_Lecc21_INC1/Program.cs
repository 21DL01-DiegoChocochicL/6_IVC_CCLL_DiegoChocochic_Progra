internal class Program
{
    private static void Main(string[] args)
    {
        //Inicio
        Console.WriteLine("Escribe un numero (1-7)");
        int n = int.Parse(Console.ReadLine());
        //Proceso, Salida y Evaluar
        if (n == 1)
        {
            Console.WriteLine("Hoy es Lunes");
        }
        else if (n == 2) 
        {
            Console.WriteLine("Hoy es Martes");
        }
        else if (n == 3)
        {
            Console.WriteLine("Hoy es Miercoles");
        }
        else if (n == 4)
        {
            Console.WriteLine("Hoy es Jueves");
        }
        else if (n == 5)
        {
            Console.WriteLine("Hoy es Viernes");
        }
        else if (n == 6)
        {
            Console.WriteLine("Hoy es Sabado");
        }
        else if (n == 7)
        {
            Console.WriteLine("Hoy es Domingo");
        }
        else
        {
            Console.WriteLine("Numero no valido");
        }
    }
}