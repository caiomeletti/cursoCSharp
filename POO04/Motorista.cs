public class Motorista
{
    private int idade;

    public void Dirigir(Veiculo veiculo)
    {
        veiculo.Ligar();
        veiculo.Acelerar();
    }
}