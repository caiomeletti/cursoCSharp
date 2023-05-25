public class Program
{
    public static void Main(string[] args)
    {
        Impressora p = new Impressora();
        p.Imprimir(3);
        p.Imprimir("Avante!");
    }
}

public class Impressora
{
    public void Imprimir(int numero)
    {
        Console.WriteLine($"Imprimindo um numero: {numero}");
    }

    public void Imprimir(string palavra)
    {
        Console.WriteLine($"Imprimindo uma palavra: {palavra}");
    }
}