using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira o saldo inicial: ");
        decimal saldoInicial = decimal.Parse(Console.ReadLine());

        ContaBancaria conta = new ContaBancaria(1, saldoInicial);

        while (true)
        {
            Console.WriteLine("\nEscolha uma operação:");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Sacar");
            Console.WriteLine("3. Verificar saldo");
            Console.WriteLine("4. Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Insira o valor a depositar: ");
                    decimal valorDeposito = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    break;

                case 2:
                    Console.Write("Insira o valor a sacar: ");
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    break;

                case 3:
                    conta.VerificarSaldo();
                    break;

                case 4:
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
