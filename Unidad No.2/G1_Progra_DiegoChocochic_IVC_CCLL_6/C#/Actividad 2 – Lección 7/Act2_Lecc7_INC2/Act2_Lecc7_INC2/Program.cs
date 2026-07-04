internal class Program
{
    private static void Main(string[] args)
    {
        //Inicio
        Console.WriteLine("Digame el nombre de la clase: ");
        string N = Console.ReadLine();
        Console.WriteLine("Digame la calificacion de esta: ");
        double cali= Double.Parse(Console.ReadLine());
        //Proceso, Salida y Evaluar
        if (cali <= 69)
        {
            Console.WriteLine(N+ " su calificacion indica que su calificacion es deficiente.");
        } else if (cali <= 7)
        {
            Console.WriteLine(N+ " su calificacion indica que su calificacion es regular.");
        } else if (cali <= 89)
        {
            Console.WriteLine(N+ " su calificacion indica que su calificacion es Buena.");
        } else if (cali <=95){
            Console.WriteLine(N+ " su calificacion indica que su calificacion es muy buena.");
        } else {
            Console.WriteLine(N+ " su calificacion indica que su calificacion es Excelente.");
        }

    }
}