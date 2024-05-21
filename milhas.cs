//Desenvolva um programa que converta quilômetros para milhas (1 km = 0.621371 milhas).
using System;

class Program {
  static void Main() {
    Console.Write("Digite a distancia em KM: ");
    float km = float.Parse(Console.ReadLine());
    
    float milhas = km * 0.621371f;

    Console.WriteLine("A distancia em milhas é: " + milhas);
  }
}
