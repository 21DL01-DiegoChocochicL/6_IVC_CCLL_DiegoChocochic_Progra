internal class Program
{
    private static void Main(string[] args)
    {
        //Inicio
        Console.WriteLine("Digame los 3 lados del Trangulo: ");
        int L1 = int.Parse(Console.ReadLine());
        int L2 = int.Parse(Console.ReadLine());
        int L3 = int.Parse(Console.ReadLine());
        //Proceso, Salida y Evaluar
        if (L1 == L2 && L1 == L3)
        {
            Console.WriteLine("Los tres lados son Iguales, eso dice que es Equilatero.");
        }
        else if (L1!=L2 && L1 == L3 || L1 == L2 && L1!=L3 || L2== L3)
        {
            Console.WriteLine("Los dos lados son Iguales, eso dice que es Isosceles.");
        }
        else
        {
            Console.WriteLine("Los tres lados son diferentes, eso dice que es Escaleno.");
        }
    }
}