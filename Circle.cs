//calcule a área de um círculo, solicitando ao usuário o valor do raio
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor do raio do circulo: ");
        double raio = double.Parse(Console.ReadLine());

        // area do circulo
        double area = Math.PI * Math.Pow(raio, 2);

        Console.WriteLine($"A area do circulo é: {area}");
    }
}
