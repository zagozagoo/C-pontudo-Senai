//2. Desenvolva um programa que leia uma matriz 2x2 de números inteiros e calcule o determinante da matriz.
using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Cálculo do determinante
        int determinante = matriz[0, 0] * matriz[1, 1] - matriz[0, 1] * matriz[1, 0];

        // Exibição da matriz
        Console.WriteLine("A matriz 2x2 é:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Exibição do determinante
        Console.WriteLine($"O determinante da matriz é: {determinante}");
    }
}
