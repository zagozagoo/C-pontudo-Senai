using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro numero inteiro: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo numero inteiro: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha a operação que deseja realizar:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.Write("Digite o número da operação escolhida: ");
        int operacao = int.Parse(Console.ReadLine());

        double resultado = 0;
        bool operacaoValida = true;

        switch (operacao)
        {
            case 1:
                resultado = numero1 + numero2;
                Console.WriteLine($"Resultado da soma: {resultado}");
                break;
            case 2:
                resultado = numero1 - numero2;
                Console.WriteLine($"Resultado da subtração: {resultado}");
                break;
            case 3:
                resultado = numero1 * numero2;
                Console.WriteLine($"Resultado da multiplicação: {resultado}");
                break;
            case 4:
                if (numero2 != 0)
                {
                    resultado = (double)numero1 / numero2;
                    Console.WriteLine($"Resultado da divisão: {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
                break;
            default:
                operacaoValida = false;
                Console.WriteLine("Operação inválida. Por favor, escolha uma operação entre 1 e 4.");
                break;
        }

        // Opcional: Informa o usuario sobre a escolha invalida
        if (!operacaoValida)
        {
            Console.WriteLine("Você não escolheu uma operação válida. O programa será encerrado.");
        }
    }
}
