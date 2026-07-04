internal class Program
{
    private static void Main(string[] args)
    {
        // Entrada
        int dia, mes;
        string estacion = "";
        Console.WriteLine("Ingrese el número del día (1-31):");
        dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el número del mes (1-12):");
        mes = int.Parse(Console.ReadLine());

        // Proceso y evaluar
        if (mes == 1 || mes == 2)
        {
            estacion = "Invierno";
        }
        else if (mes == 3)
        {
            if (dia < 21) { estacion = "Invierno"; }
            else { estacion = "Primavera"; }
        }
        else if (mes == 4 || mes == 5)
        {
            estacion = "Primavera";
        }
        else if (mes == 6)
        {
            if (dia < 21) { estacion = "Primavera"; }
            else { estacion = "Verano"; }
        }
        else if (mes == 7 || mes == 8)
        {
            estacion = "Verano";
        }
        else if (mes == 9)
        {
            if (dia < 21) { estacion = "Verano"; }
            else { estacion = "Otoño"; }
        }
        else if (mes == 10 || mes == 11)
        {
            estacion = "Otoño";
        }
        else if (mes == 12)
        {
            if (dia < 21) { estacion = "Otoño"; }
            else { estacion = "Invierno"; }
        }
        else
        {
            Console.WriteLine("El mes no es válido.");
            return; // Finaliza el programa si el mes es incorrecto
        }

        // Salida de resultados
        Console.WriteLine("La estación correspondiente es: " + estacion);
    }
}