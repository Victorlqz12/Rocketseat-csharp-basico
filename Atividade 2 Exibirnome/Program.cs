class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu primeiro nome:");
        string PrimeiroNome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome:");
        string Sobrenome = Console.ReadLine();

        Console.WriteLine($"Seu nome completo é: {PrimeiroNome} {Sobrenome}");
    }
}

