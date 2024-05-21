//Crie um programa que leia 5 números inteiros e os armazene em um vetor. Em seguida, exiba os números na ordem inversa.
using System;

class Program {
  static void Main(){
    int[] vetor = new int[5];

    Console.WriteLine("Insira 5 numeros inteiros: ");

    for (int i = 0; i < 5; i++){
        vetor[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("\nNumeros na ordem inversa:");

    for (int i = 4; i >= 0; i--){
        Console.WriteLine(vetor[i]);
    }
  }
}
