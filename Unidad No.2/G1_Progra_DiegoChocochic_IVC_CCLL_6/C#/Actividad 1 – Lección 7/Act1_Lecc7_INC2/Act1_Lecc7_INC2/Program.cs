internal class Program
{
    private static void Main(string[] args)
    {
        //Entrada
        Console.WriteLine("Digame su nombre: ");
        string N = Console.ReadLine();
        Console.WriteLine("Digame su edad: ");
        int edad = int.Parse(Console.ReadLine());
        //Proceso, Salida y evaluar
        if (edad >= 18)
        {
            Console.WriteLine(N+ " es mayor de edad, "+ edad+ " años");
        }
        else
        {
            Console.WriteLine(N+ " es menor de edad, "+ edad+ " años");
        }
    }
}