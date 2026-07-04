namespace Act2_Lecc11_inciso3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n1, n2, menor, mayor, i;

            Console.WriteLine("*******************************************");
            Console.WriteLine("    BUSCADOR DE MÚLTIPLOS DE 4 EN RANGO    ");
            Console.WriteLine("*******************************************");

            Console.Write("Ingrese el primer número: ");
            n1 = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el segundo número: ");
            n2 = int.Parse(Console.ReadLine()!);

            if (n1 < n2) { menor = n1; mayor = n2; }
            else { menor = n2; mayor = n1; }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Múltiplos de 4 entre " + menor + " y " + mayor + ":");

            i = menor;
            do
            {
                if (i % 4 == 0)
                    Console.WriteLine(i);
                i++;
            } while (i <= mayor);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Proceso finalizado.");
            Console.WriteLine("*******************************************");
        }
    }
}
