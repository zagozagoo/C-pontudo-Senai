//Desenvolva um programa que leia 10 números inteiros e armazene em um vetor. Calcule e exiba a média dos números.
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
      
        int soma = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            soma += numeros[i];
        }

        double media = (double)soma / numeros.Length;

        Console.WriteLine($"A media dos numeros é: {media}");
    }
}
