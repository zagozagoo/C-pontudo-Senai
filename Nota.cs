//solicite a nota de um aluno e informe se ele foi aprovado (nota >= 6) ou reprovado.
using System;

class Program {
  static void Main (){
    Console.Write("Digite a nota do aluno: ");
    double nota = double.Parse(Console.ReadLine());

    if(nota >= 6){
      Console.WriteLine("O aluno foi aprovado");
    }
    else {
      Console.WriteLine("O aluno foi reprovado");
    }
  }
}
