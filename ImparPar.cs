//leia um número e verifique se ele é par ou ímpar
using System; 

class Program {
  static void Main(){
    Console.Write("Digite um numero: ");
    int num = int.Parse(Console.ReadLine());

    if(num % 2 == 0){
      Console.WriteLine("O numero é par");
    }
    else {
      Console.WriteLine("O numero é impar");
    }
  }
}
