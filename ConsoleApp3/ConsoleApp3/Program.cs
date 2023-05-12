public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Qual é o seu nome? ");

        string nome = Console.ReadLine();

        Console.WriteLine($"Olá {nome}"); //interpolação
        Console.WriteLine("Olá " + nome); //concatenação
        Console.WriteLine(string.Format("Olá {0}", nome)); //string.format
    }
}
