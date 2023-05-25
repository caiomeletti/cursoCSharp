public class Carro : Veiculo
{
    public override void Ligar()
    {
        Console.WriteLine("Girando a chave...");
    }

    public override void Acelerar()
    {
        Console.WriteLine("Pisando no acelerador...");
    }

    public void AcionarFreioMao()
    {
        Console.WriteLine("Freio de mão acionado.");
    }
}