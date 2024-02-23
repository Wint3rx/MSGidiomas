using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione su idioma de preferencia (español, inglés, francés): ");
        string idioma = Console.ReadLine().ToLower(); // Convertir a minúsculas para manejar entradas mixtas

        string mensajeBienvenida = MensajeBienvenida(idioma);

        if (mensajeBienvenida != null)
        {
            Console.WriteLine(mensajeBienvenida);
        }
        else
        {
            Console.WriteLine("Idioma no válido. Por favor, seleccione uno de los idiomas mencionados.");
        }
    }

    static string MensajeBienvenida(string idioma)
    {
        switch (idioma)
        {
            case "español" or "espanol":
                return "¡Bienvenido!";
            case "inglés" or "english":
                return "Welcome!";
            case "francés" or "french":
                return "Bienvenue!";
            default:
                return null; // Indica que el idioma no es válido
        }
    }
}

