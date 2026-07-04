internal class Program
{
    private static void Main(string[] args)
    {
        //Entrada
        Console.WriteLine("Promedio de Calificaciones");
        Console.WriteLine("Escriba la Materia: ");
        string M = Console.ReadLine();

        Console.WriteLine("Dame las 5 notas de la Materia: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        double n2 = Convert.ToDouble(Console.ReadLine());
        double n3 = Convert.ToDouble(Console.ReadLine());
        double n4 = Convert.ToDouble(Console.ReadLine());
        double n5 = Convert.ToDouble(Console.ReadLine());

        //Proceso 
        double Prom = (n1 + n2 + n3 + n4 + n5) / 5;

        //Evaluar
        if (Prom >= 70)
        {
            Console.WriteLine("El alumno ha ganado la clase " + M + " con un Promedio de: " + Prom + "Pts");
        }
        else
        {
            Console.WriteLine("El alumno ha perdido la clase " + M + " con un Promedio de: " + Prom + "Pts");
        }
    }
}