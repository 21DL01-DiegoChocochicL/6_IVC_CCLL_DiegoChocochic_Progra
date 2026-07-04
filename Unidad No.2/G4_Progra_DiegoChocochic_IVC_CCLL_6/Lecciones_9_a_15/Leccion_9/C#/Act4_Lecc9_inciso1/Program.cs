namespace Act4_Lecc9_inciso1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n, i, resultado;

            Console.WriteLine("*******************************************");
            Console.WriteLine("      GENERADOR DE TABLAS DE MULTIPLICAR   ");
            Console.WriteLine("*******************************************");
            Console.Write("Ingrese el número para la tabla de multiplicar: ");
            n = int.Parse(Console.ReadLine()!);

            i = 1;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Tabla del " + n + ":");

            while (i <= 10)
            {
                resultado = n * i;
                Console.WriteLine(n + " x " + i + " = " + resultado);
                i++;
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Proceso finalizado.");
            Console.WriteLine("*******************************************");
        }
    }
}
