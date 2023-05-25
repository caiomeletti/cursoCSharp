public class Cachorro : Mamifero
{
    private string nomeSocial;

    public Cachorro(string nomeCientifico, string nomeSocial) : base(nomeCientifico)
    {
        this.nomeSocial = nomeSocial;
    }

    public void Latir()
    {
        Console.WriteLine("Woof Woof...");
    }
}