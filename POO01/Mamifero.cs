public class Mamifero
{
    private string nomeCientifico;

    public Mamifero(string nomeCientifico)
    {
        this.nomeCientifico = nomeCientifico;
    }

    public void Respirar()
    {
        Console.WriteLine($"'{nomeCientifico}' inspirando, expirando ...");
    }
}