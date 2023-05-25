public class Motocicleta : Veiculo
{
    public override void Ligar()
    {
        Console.WriteLine("Girando a chave e acionando o botão de ignição...");
    }

    public override void Acelerar()
    {
        Console.WriteLine("Girando a manopla do acelerador...");
    }

    public void Empinar()
    {
        Console.WriteLine("Cai de costa...");
    }

}