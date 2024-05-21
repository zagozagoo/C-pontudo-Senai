using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha a conversão que deseja realizar:");
        Console.WriteLine("1 - Converter de Km para Milhas");
        Console.WriteLine("2 - Converter de Milhas para Km");
        Console.Write("Digite o número da conversão escolhida: ");
        int escolha = int.Parse(Console.ReadLine());

        double resultado = 0;
        const double fatorConversao = 0.621371;

        switch (escolha)
        {
            case 1:
                Console.Write("Digite o valor em quilômetros: ");
                double km = double.Parse(Console.ReadLine());
                resultado = km * fatorConversao;
                Console.WriteLine($"{km} Km equivalem a {resultado} Milhas.");
                break;
            case 2:
                Console.Write("Digite o valor em milhas: ");
                double milhas = double.Parse(Console.ReadLine());
                resultado = milhas / fatorConversao;
                Console.WriteLine($"{milhas} Milhas equivalem a {resultado} Km.");
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha 1 ou 2.");
                break;
        }
    }
}
