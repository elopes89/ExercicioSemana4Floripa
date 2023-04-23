using Semana1Floripa.Model;

namespace ExercicioSemana4Floripa.Model;

public class ContaEmpresarial : ContaBancaria
{
    public double limiteEmprestimo { get; private set; }
    public double taxaDeJuros { get; private set; }
    public bool possuiEmprestimo { get; private set; }
    public double valorUsado { get; private set; }
    public string CNPJ { get; private set; }

    public bool FazerEmprestimo(double valor)
    {
        if (valor > limiteEmprestimo)
        {
            Saldo = Saldo + valor;
            possuiEmprestimo = false;
            return false;
        }
        else
        {
            return true;
        }
    }

    public bool PagarEmprestimo(double valor)
    {
        if (valor < Saldo)
        {
            possuiEmprestimo = false;
            return true;
        }
        else
            return false;
    }

    public bool Sacar(double valor)
    {
        valor = 1;
        Saldo = Saldo - 1;
        return true;
    }

    public bool Transferencia(double valor)
    {
        valor = .5;
        Saldo = _saldo - valor;
        return true;
    }
}
