//Desenvolva um programa que use um laço for para calcular a soma dos números de 1 a 100
using System;

class Program {
    static void Main() {
        int soma = 0;

        for (int i = 1; i <= 100; i++) {
            soma += i;
        }

        Console.WriteLine("A soma dos números de 1 a 100 é: " + soma);
    }
}
