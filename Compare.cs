//Crie um programa que leia dois números inteiros e verifique se o primeiro número é maior que o segundo.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("O numero " + num1 + " é maior que o numero " + num2);
          }
        else if (num1 < num2)
        {
            Console.WriteLine($"O numero {num1} é menor que o numero {num2}");
        }
        else
        {
            Console.WriteLine("Os numeros são iguais");
        }
    }
}
