using Semana1Floripa.Model;

namespace ExercicioSemana4Floripa.Model;

public class ContaPoupanca : ContaBancaria
{
    private const int V = 1;

    private int _numero { get; set; }
    private int _agencia { get; set; }

    private string _nomeTitular { get; set; }
    public double _saldo { get; private set; } = 0d;

    public bool Sacar(double valor)
    {
        valor = .1;
        _saldo = _saldo - valor;
        return true;
    }

    public bool Transferir(double valor)
    {
        valor = .05;
        _saldo = _saldo - valor;
        return true;
    }
}
 