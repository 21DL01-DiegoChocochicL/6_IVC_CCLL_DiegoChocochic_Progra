internal class Program
{
    private static void Main(string[] args)
    {
        // El Estadio Doroteo Guamuch Flores es uno de los estadios más importantes de Centroamérica. Este
        // estadio tiene diversos sectores, el costo de la entrada a los eventos futbolísticos del estadio se asignan en
        // virtud de los sectores del estadio mediante la siguiente lista:
        // -Palco: Q300.00
        // -Tribuna: Q100.00 - Q125.00
        // -Preferencia: Q50.00 - Q75.00
        // -Generales: Q30.00 - Q50.00
        // Se pide construir un programa que permita seleccionar un sector del estadio, ingresar la cantidad de
        // entradas solicitadas y calcular el total a pagar por las entradas

        // Inicio
        Console.WriteLine("\t* Estadio Doroteo Guamuch Flores");
        Console.WriteLine("\t**********************************************");
        Console.WriteLine("\t* Precios                                    *");
        Console.WriteLine("\t* 1- Palco: Q300.00                          *");
        Console.WriteLine("\t* 2- Tribuna: Q100.00 - Q125.00              *");
        Console.WriteLine("\t* 3- Preferencia: Q50.00 - Q75.00            *");
        Console.WriteLine("\t* 4- Generales: Q30.00 - Q50.00              *");
        Console.WriteLine("\t**********************************************");

        Console.Write("Cual Sector prefiere: ");
        int s = int.Parse(Console.ReadLine());

        Console.WriteLine("Cuantos boletos necesita: ");
        int c = int.Parse(Console.ReadLine());

        // Sentencia de Seleccion, Proceso y Salida
        switch (s)
        {
            case 1:
                Console.WriteLine("Ok, necesita "+ c + " boletos, en el sector, del Palco, el total seria, "+ (c*300.00)+ "Q");
                break;
            case 2: 
                Console.WriteLine("Ok, necesita " + c + " boletos, en el sector, del Tribuna, el total seria, " + (c * 100.00) + "Q" + " a " + (c * 125.00)+ "Q");
                break;
            case 3:
                Console.WriteLine("Ok, necesita " + c + " boletos, en el sector, de Preferencia, el total seria, " + (c * 50.00) + "Q" + " a " + (c * 75.00) + "Q");
                break;
            case 4:
                Console.WriteLine("Ok, necesita " + c + " boletos, en el sector, General, el total seria, " + (c * 30.00) + "Q" + " a " + (c * 50.00) + "Q");
                break;
            default:
                Console.WriteLine("Valor no valido");
                break;
        }
    }
}