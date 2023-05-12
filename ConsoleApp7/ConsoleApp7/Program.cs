public class Program
{
    public static void Main(string[] args)
    {
        const int ANO_ATUAL = 2023;
        Console.WriteLine("Insira o ano de nascimento:");
        int anoNascimento = int.Parse(Console.ReadLine());
        int idade = ANO_ATUAL - anoNascimento;

        if (idade >= 65)
            Console.WriteLine("Geração Silenciosa");
        else if (idade >= 50 && idade < 65)
            Console.WriteLine("Baby boommer");
        else if (idade >= 35 && idade < 50)
            Console.WriteLine("Geração X");
        else if (idade >= 21 && idade < 35)
            Console.WriteLine("Geração Y");
        else if (idade >= 15 && idade < 21)
            Console.WriteLine("Geração Z");
        else
            Console.WriteLine("não sei");
    }
}
