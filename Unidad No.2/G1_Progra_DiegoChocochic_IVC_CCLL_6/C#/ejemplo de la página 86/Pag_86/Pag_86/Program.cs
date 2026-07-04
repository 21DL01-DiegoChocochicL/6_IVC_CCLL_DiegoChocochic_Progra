internal class Program
{
    private static void Main(string[] args)
    {
        //Inicio
        int num = 0;
        Console.WriteLine("Introduzca un numero: ");
        num= int.Parse(Console.ReadLine());
        //Proceso,Salida y evaluar
        if (num < 0)
        {
            Console.WriteLine("El numero es menor a cero");
        }
        else
        {
            Console.WriteLine("El numero es igual o mayor a cero");
        }
    }
}