//leia um número do usuário e exiba o triplo desse número

using System;

class Program {
  static void Main() {
    Console.Write("Digite um número: ");
    float num = float.Parse(Console.ReadLine());

    float triplo = num * 3;

    Console.WriteLine("O triplo de " + num + " é: " + triplo);
  }
}
