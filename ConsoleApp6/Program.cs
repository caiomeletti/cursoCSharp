public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Inserir o primeiro número:");
        int numA = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserir o segundo número:");
        int numB = int.Parse(Console.ReadLine());

        int maior;
        if (numA > numB)
            maior = numA;
        else
            maior = numB;

        Console.WriteLine(maior+ " é maior");
    }
}
