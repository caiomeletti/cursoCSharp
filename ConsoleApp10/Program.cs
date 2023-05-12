public class Program
{
    public static void Main(string[] args)
    {
        int numA = -1;
        while (numA < 1 || numA > 10)
        {
            Console.WriteLine("Digite um número de 1 a 10");
            numA = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"O número {numA} está dentro do limite válido.");
    }
}
