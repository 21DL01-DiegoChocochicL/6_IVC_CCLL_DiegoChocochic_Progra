internal class Program
{
    private static void Main(string[] args)
    {
        //El ususario ingresa su fecha de nacimiento (mes y dia) y el programa le muestra su signo zodiacal y un horoscopo
        Console.WriteLine("Nombre:Diego Alejandro Chocochic L.\n" + "Grado:IV Bach. CC.LL\n" + "Seccion:C\n" + "Calve:6\n"
        + "Horoscopo\n" + "");

        Console.Write("Ingrese su día de nacimiento (1-31): ");
        int dia = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su mes de nacimiento (1-12): ");
        int mes = Convert.ToInt32(Console.ReadLine());

        string signo = "";
        string prediccion = "";

        if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
        {
            signo = "Aries";
            prediccion = "Hoy es un excelente día para empezar nuevos proyectos con energía.";
        }
        else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
        {
            signo = "Tauro";
            prediccion = "La paciencia será tu mejor aliada hoy. Mantén la calma.";
        }
        else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
        {
            signo = "Géminis";
            prediccion = "Tu curiosidad te llevará a descubrir algo muy interesante hoy.";
        }
        else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
        {
            signo = "Cáncer";
            prediccion = "Dedica tiempo a tus seres queridos; te recargará de buena vibra.";
        }
        else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
        {
            signo = "Leo";
            prediccion = "Brillarás en lo que hagas hoy, confía plenamente en tu talento.";
        }
        else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
        {
            signo = "Virgo";
            prediccion = "Un poco de orden en tus pendientes te dará mucha tranquilidad.";
        }
        else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
        {
            signo = "Libra";
            prediccion = "Busca el equilibrio en tus decisiones y todo saldrá excelente.";
        }
        else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
        {
            signo = "Escorpio";
            prediccion = "Tu intuición está muy aguda hoy, hazle caso a tu corazonada.";
        }
        else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
        {
            signo = "Sagitario";
            prediccion = "Una aventura o sorpresa agradable te espera a la vuelta de la esquina.";
        }
        else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
        {
            signo = "Capricornio";
            prediccion = "Tu esfuerzo dará frutos pronto. No te rindas ahora.";
        }
        else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
        {
            signo = "Acuario";
            prediccion = "Tu mente creativa está al máximo, es hora de plasmar tus ideas.";
        }
        else if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20))
        {
            signo = "Piscis";
            prediccion = "Conéctate con tu lado artístico; hoy fluirá mucho amor a tu alrededor.";
        }
        else
        {
            Console.WriteLine("Fecha no válida.");
            return;
        }

        Console.WriteLine($"\nTu signo zodiacal es: {signo}");
        Console.WriteLine($"Horóscopo: {prediccion}");
    }
}