using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma ou mais palavras (separe-as por espaço):");
        string entrada = Console.ReadLine();

        // Divide a frase em palavras
        string[] palavras = entrada.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("\nQuantidade de caracteres em cada palavra:");
        foreach (string palavra in palavras)
        {
            Console.WriteLine($"- {palavra}: {palavra.Length} caracteres");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}

