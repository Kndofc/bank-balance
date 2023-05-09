using System;
using MySql.Data.MySqlClient;

public class ContaBancariaDAO
{
    private MySqlConnection conexao;

    public ContaBancariaDAO()
    {
        string connectionString = "Server=localhost;Database=banco;Uid=root;Pwd=ka010883";
        conexao = new MySqlConnection(connectionString);
    }

    public void InicializarSaldo(decimal saldo)
    {
        try
        {
            conexao.Open();
            string sql = $"INSERT INTO contas_bancarias (saldo) VALUES ({saldo})";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao inicializar o saldo: {ex.Message}");
        }
    }

    public void AddTransacao(ContaBancaria conta, string tipo, decimal valor)
    {
        try
        {
            conexao.Open();
            string sql = $"INSERT INTO transacoes (conta_id, tipo, valor) VALUES ({conta.Id}, '{tipo}', {valor})";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao adicionar transação: {ex.Message}");
        }
    }
}
