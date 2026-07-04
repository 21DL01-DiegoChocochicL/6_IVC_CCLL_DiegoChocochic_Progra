namespace Act3_Lecc11_inciso1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n1, n2, menor, mayor, i, suma;
            suma = 0;

            Console.WriteLine("*******************************************");
            Console.WriteLine("      SUMATORIA DE RANGO NUMÉRICO          ");
            Console.WriteLine("*******************************************");

            Console.Write("Ingrese el primer número: ");
            n1 = int.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el segundo número: ");
            n2 = int.Parse(Console.ReadLine()!);

            if (n1 < n2) { menor = n1; mayor = n2; }
            else { menor = n2; mayor = n1; }

            i = menor;
            do
            {
                suma += i;
                i++;
            } while (i <= mayor);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("La suma de los números entre " + menor + " y " + mayor + " es: " + suma);
            Console.WriteLine("*******************************************");
        }
    }
}
