public class Veiculo
{
    private string marca;
    private string modelo;
    private Cor cor;

    public virtual void Ligar()
    {
        Console.WriteLine("Ligando o veículo...");
    }

    public virtual void Acelerar()
    {
        Console.WriteLine("Acelerando...");
    }

    public void Frear()
    {
        Console.WriteLine("Pisando no freio...");
    }

}

public enum Cor
{
    Violeta,
    Anil,
    Azul,
    Verde,
    Amarelo,
    Laranja,
    Vermelho,
    Branco,
    Preto
}