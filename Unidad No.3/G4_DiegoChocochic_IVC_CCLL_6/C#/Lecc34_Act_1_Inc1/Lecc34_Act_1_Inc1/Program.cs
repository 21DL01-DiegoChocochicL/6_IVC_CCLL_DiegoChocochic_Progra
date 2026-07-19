internal class Program
{
    private static void Main(string[] args)
    {
        //Convierte un numero decimal a binario y viceversa
        Console.WriteLine("Nombre:Diego Alejandro Chocochic L.\n" + "Grado:IV Bach. CC.LL\n" + "Seccion:C\n" + "Calve:6\n"
        + "Retos\n" + "");

        Console.WriteLine("========================================");
        Console.WriteLine("    Conversor Decimal a Binario       ");
        Console.WriteLine("========================================");
        Console.WriteLine("1. Convertir de Decimal a Binario");
        Console.WriteLine("2. Convertir de Binario a Decimal");
        Console.Write("Seleccione una opción: ");
        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            Console.Write("\nIngrese un número entero decimal positivo: ");
            int decimalNum = Convert.ToInt32(Console.ReadLine());

            if (decimalNum < 0)
            {
                Console.WriteLine("Por favor, ingrese un número no negativo.");
                return;
            }

            if (decimalNum == 0)
            {
                Console.WriteLine("El número en binario es: 0");
                return;
            }

            string binario = "";
            int temp = decimalNum;

            while (temp > 0)
            {
                int residuo = temp % 2;
                binario = residuo.ToString() + binario; 
                temp = temp / 2;
            }

            Console.WriteLine($"El número {decimalNum} en binario es: {binario}");
        }
        else if (opcion == "2")
        {
            Console.Write("\nIngrese un número binario: ");
            string binarioStr = Console.ReadLine();

            foreach (char c in binarioStr)
            {
                if (c != '0' && c != '1')
                {
                    Console.WriteLine("Error: El valor ingresado no es un número binario válido.");
                    return;
                }
            }

            double decimalResultado = 0;
            int longitud = binarioStr.Length;

            for (int i = 0; i < longitud; i++)
            {
                char caracter = binarioStr[longitud - 1 - i];
                int digito = (int)char.GetNumericValue(caracter);

                decimalResultado += digito * Math.Pow(2, i);
            }

            Console.WriteLine($"El binario {binarioStr} en decimal es: {decimalResultado}");
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }
}