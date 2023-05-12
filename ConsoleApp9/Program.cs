public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Insira um número:");
        int numA = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 50; i++)
        {
            Console.WriteLine(i + numA);
        }
    }
}
