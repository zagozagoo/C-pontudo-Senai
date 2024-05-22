//1. Crie um programa que leia uma matriz 3x3 de números inteiros do usuário e exiba a matriz.
using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("A matriz 3x3 é:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
