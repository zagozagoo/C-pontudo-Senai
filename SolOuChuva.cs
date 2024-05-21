//peça ao usuário para informar se está chovendo e se está ensolarado, e determine se é um bom dia para sair de casa.
using System;

class Program {
  static void Main() {
    Console.Write("Está chovendo? (s/n): ");
    string Chovendo = Console.ReadLine();
    Console.Write("Está ensolarado? (s/n): ")
    string Ensolarado = Console.ReadLine();

    if (Chovendo == "s" && Ensolarado == "s") {
      Console.WriteLine("Apesar da chuva, é um bom dia para sair de casa");
    }
    else if (Chovendo == "s" && Ensolarado == "n") {
      Console.WriteLine("Hoje não é um bom dia para sair de casa, está chovendo");
    }
    else if (Chovendo == "n" && Ensolarado == "s") {
      Console.WriteLine("Hoje é um bom dia para sair de casa, está ensolarado");
    }
    else {
      Console.WriteLine("Hoje é um dia que voc~e ode sair, apesar de não estar ensolarado");
    }
  }
}
