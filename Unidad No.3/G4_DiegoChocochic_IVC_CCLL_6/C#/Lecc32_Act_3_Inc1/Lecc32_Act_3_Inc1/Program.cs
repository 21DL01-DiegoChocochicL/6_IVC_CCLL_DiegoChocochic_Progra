internal class Program
{
    private static void Main(string[] args)
    {
        //Reciba las medidas de los tres lados de un triangulo e indique si se trata de un  triangulo equilatero, isoceles
        //o escaleno. No importa el orden en que se den las medidas
        Console.WriteLine("Nombre:Diego Alejandro Chocochic L.\n" + "Grado:IV Bach. CC.LL\n" + "Seccion:C\n" + "Calve:6\n"
        + "Triangulos\n" + "");

        Console.Write("Ingrese el lado 1: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el lado 2: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el lado 3: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es Equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es Isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es Escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Las medidas ingresadas no forman un triángulo válido.");
        }
    }
}