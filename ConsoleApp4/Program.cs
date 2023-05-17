public class Program
{
    public static void Main(string[] args)
    {
        string? numString = string.Empty;
        int numA = 0;
        int numB = 0;
        bool parseOK = false;
        do
        {
            Console.WriteLine("Inserir o primeiro número:");
            numString = Console.ReadLine();
        } while (!int.TryParse(numString, out numA));

        do
        {
            Console.WriteLine("Inserir o segundo número:");
            numString = Console.ReadLine();

            if (int.TryParse(numString, out numB))
                parseOK = true;
            else
            {
                parseOK = false;
                Console.WriteLine("O número inserido é inválido!");
            }

        } while (!parseOK);

        Console.WriteLine("A soma do números é " + (numA + numB));
    }
}
