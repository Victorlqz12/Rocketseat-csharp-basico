using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        DateTime agora = DateTime.Now;

        
        Console.WriteLine("Formato completo:");
        Console.WriteLine(agora.ToString("dddd, dd/MM/yyyy HH:mm:ss"));

       
        Console.WriteLine("\nApenas a data (dd/MM/yyyy):");
        Console.WriteLine(agora.ToString("dd/MM/yyyy"));

       
        Console.WriteLine("\nApenas a hora (HH:mm:ss):");
        Console.WriteLine(agora.ToString("HH:mm:ss"));

        
        Console.WriteLine("\nData com o mês por extenso:");
        Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
