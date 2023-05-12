public class Program
{
    public static void Main(string[] args)
    {
        const int ANO_ATUAL = 2023;
        Console.WriteLine("Qual o seu ano de nascimento?");
        int anoNasc = int.Parse(Console.ReadLine());
        int idade = ANO_ATUAL - anoNasc;
        Console.WriteLine($"Você tem {idade} anos de idade.");
    }
}
