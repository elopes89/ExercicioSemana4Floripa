using System;
using ExercicioSemana3Floripa.Model;
using ExercicioSemana4Floripa.Model;
using Semana1Floripa.Model;

namespace projetoConsole;

public class Program
{

    public static void Main(string[] args)
    {
        ContaBancaria contaOrigem = new ContaBancaria();
        ContaBancaria contaDestino = new ContaBancaria();
        ContaPoupanca poupanca = new ContaPoupanca();

        contaOrigem.Saldo = 1000.0;
        contaOrigem.Numero = 123;
        contaDestino.Numero = 777;
        poupanca.Depositar(6789);
        poupanca.Sacar(300);

        System.Console.WriteLine("Transferência: " , contaOrigem.Transferencia(contaDestino, 600.0));
        System.Console.WriteLine(contaOrigem.Saldo);
        System.Console.WriteLine(contaDestino.Saldo);
        System.Console.WriteLine(contaDestino.Numero);
        System.Console.WriteLine(poupanca.Saldo);
    }

}

