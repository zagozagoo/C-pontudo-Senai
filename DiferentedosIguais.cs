//peça ao usuário dois números e informe se eles são iguais ou diferentes
using System;

class Program {
  static void Main() {
    Console.Write("Digite o primeiro número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int num2 = int.Parse(Console.ReadLine());

    if (num1 == num2) {
      Console.WriteLine("Os numeros são iguais");
    }
    else {
      Console.WriteLine("Os numeros são diferentes");
    }
  }
}
