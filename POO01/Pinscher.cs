public class Pinscher : Cachorro
{
    public Pinscher(string nomeCientifico, string nomeSocial) : base(nomeCientifico, nomeSocial)
    {
    }

    public void ModoRaiva()
    {
        Console.WriteLine("Entrando em modo raiva!");
    }
}