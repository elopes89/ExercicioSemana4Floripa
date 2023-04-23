namespace Semana1Floripa.Model;

public class ContaBancaria
{
    private int _numero { get; set; }
    private int _agencia { get; set; }
    private string _nomeTitular { get; set; }

    public double _saldo { get; private set; } = 0d;

    public int Numero
    {
        get { return _numero; }
        set { _numero = value; }
    }

    public string NomeTitular
    {
        get { return _nomeTitular; }
        set { _nomeTitular = value; }
    }

    public int Agencia
    {
        get { return _agencia; }
        set { _agencia = value; }
    }

    public double Saldo
    {
        get { return _saldo; }
        set { _saldo = value; }
    }

    private ETipoConta _Tc { get; set; }

    public ContaBancaria()
    {

    }
    public ContaBancaria(int numero, int agencia, string nome, double saldo, ETipoConta tipo)
    {
        _nomeTitular = nome;
        _agencia = agencia;
        _numero = numero;
        _Tc = tipo;
    }

    public ContaBancaria(string nome, ETipoConta tipo)
    {
        _nomeTitular = nome;
        _Tc = tipo;
    }

    public double Depositar(double deposito)
    {
        if (deposito > 0)
        {
            Saldo += deposito;
        }
        return Saldo;
    }

    public bool Sacar(double saque)
    {
        if (saque > 0 & saque < _saldo)
        {
            _saldo -= saque;
        }
        return true;
    }

    public string ExibirSaldo()
    {
        return $"Saldo atual: {Saldo}";
    }

    public bool Transferencia(ContaBancaria destino, double valor)
    {
        if (Sacar(valor))
        {
            destino.Depositar(valor);
            return true;
        }
        return false;
    }
}



