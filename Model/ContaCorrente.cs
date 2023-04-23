using Semana1Floripa.Model;

namespace ExercicioSemana4Floripa.Model;

public class ContaCorrente : ContaBancaria
{
    public bool Transferir(double valor)
    {
         valor = 0.25;
        Saldo = Saldo - valor;
        return true;
    }

    public bool Sacar(double valor)
    {
        valor = .5;
        Saldo = Saldo - valor;
        return true;
    }
}
