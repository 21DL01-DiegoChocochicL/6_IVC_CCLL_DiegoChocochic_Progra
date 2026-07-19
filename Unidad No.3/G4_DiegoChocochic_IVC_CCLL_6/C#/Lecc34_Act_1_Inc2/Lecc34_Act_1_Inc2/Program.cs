internal class Program
{
    private static void Main(string[] args)
    {
        //Calcula el indice de masa corporal de una persona utilizando la siguiente formula:
        //IMC=peso(en kg)/altura (en m)^2
        Console.WriteLine("Nombre:Diego Alejandro Chocochic L.\n" + "Grado:IV Bach. CC.LL\n" + "Seccion:C\n" + "Calve:6\n"
        + "Peso Corporal\n" + "");

        Console.WriteLine("--- Calculadora de Índice de Masa Corporal (IMC) ---");

        Console.Write("Ingrese su peso en kilogramos (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese su altura en metros (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        if (altura > 0 && peso > 0)
        {
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"\nSu Índice de Masa Corporal (IMC) es: {imc:F2}");

            if (imc < 18.5)
                Console.WriteLine("Clasificación: Bajo peso");
            else if (imc >= 18.5 && imc < 25)
                Console.WriteLine("Clasificación: Peso normal");
            else if (imc >= 25 && imc < 30)
                Console.WriteLine("Clasificación: Sobrepeso");
            else
                Console.WriteLine("Clasificación: Obesidad");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}