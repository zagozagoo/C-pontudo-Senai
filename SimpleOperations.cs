//recebe dois numeros inteiros e faz as operações matemáticas
using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite o primeiro numero: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine ("Digite o segundo numero: ");
    int num2 = int.Parse(Console.ReadLine());

    int soma = num1 + num2;
    int sub = num1 - num2;
    int mult = num1 * num2;
    double div = (double)num1 / num2; //tem que colocar o double para que o resultado seja um numero real, não um truncado

    Console.WriteLine("\nSoma: " + soma);
    Console.WriteLine($"\nSubtracao: {sub}");
    Console.WriteLine($"\nMultiplicacao: {mult}");
    Console.WriteLine($"\nDivisao: {div}");
  }
}
