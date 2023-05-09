using System;

public class ContaBancaria
{
    public int Id { get; set; }
    private ContaBancariaDAO dao = new ContaBancariaDAO();
    public decimal Saldo { get; private set; }

    public ContaBancaria(int id, decimal saldoInicial)
    {
        if (saldoInicial < 0)
        {
            Console.WriteLine("O saldo inicial deve ser maior ou igual a zero");
            return;
        }

        this.Id = id;
        this.Saldo = saldoInicial;
        dao.InicializarSaldo(this.Saldo);
    }

    public void Sacar(decimal valor)
    {
        if (valor > this.Saldo)
        {
            Console.WriteLine("Saldo insuficiente para a transação");
            return;
        }

        this.Saldo -= valor;
        dao.AddTransacao(this, "SAQUE", valor);
        Console.WriteLine($"Saque de {valor:C} realizado com sucesso!");
    }

    public void Depositar(decimal valor)
    {
        if (valor < 0)
        {
            Console.WriteLine("O valor do depósito deve ser maior ou igual a zero");
            return;
        }

        this.Saldo += valor;
        dao.AddTransacao(this, "DEPOSITO", valor);
        Console.WriteLine($"Depósito de {valor:C} realizado com sucesso!");
    }

    public void VerificarSaldo()
    {
        Console.WriteLine($"Saldo atual: {this.Saldo:C}");
    }
}
