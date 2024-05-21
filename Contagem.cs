//Crie um programa que use um laço while para exibir os números que o usurio pede
using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Insira o numero de início da contagem: ");
    int inicio = int.Parse(Console.ReadLine());

    Console.Write("Insira o numero final da contagem: ");
    int fim = int.Parse(Console.ReadLine());
    
    Console.Write($"Exibindo números de {inicio} a {fim}: \n");

    while (inicio <= fim){
      Console.WriteLine(inicio);
      inicio++;
    }
  }
}
