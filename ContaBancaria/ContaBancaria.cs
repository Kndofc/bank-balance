using System;

public class ContaBancaria
{
    private decimal saldo;

    public ContaBancaria(decimal saldoInicial)
    {
        saldo = saldoInicial;
    }

    public void Depositar(decimal valor)
    {
        saldo += valor;
        Console.WriteLine($"Depósito realizado. Saldo atual: {saldo:C}");
    }

    public void Sacar(decimal valor)
    {
        if (saldo >= valor)
        {
            saldo -= valor;
            Console.WriteLine($"Saque realizado. Saldo atual: {saldo:C}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para saque.");
        }
    }

    public void VerificarSaldo()
    {
        Console.WriteLine($"Saldo atual: {saldo:C}");
    }
}
