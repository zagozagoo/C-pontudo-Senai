//Crie um programa que leia a idade de uma pessoa e verifique se ela pode votar (idade >= 16) e se é maior de idade (idade >= 18).
using System;

class Program {
  static void Main() {
    Console.Write("Digite a sua idade: ");
    int idade = int.Parse(Console.ReadLine());

    if (idade >= 16 && idade < 18) {
      Console.WriteLine("Você pode votar, mas não é maior de idade");
    }
    else if (idade >= 18) {
      Console.WriteLine("Você pode votar e é maior de idade");
    }
    else {
      Console.WriteLine("Você não pode votar e não é maior de idade");
    }
  }
}
