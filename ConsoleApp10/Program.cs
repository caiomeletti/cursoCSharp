public class Program
{
    public static void Main(string[] args)
    {
        int numA = -1;
        bool numValido = false;
        while (!numValido)
        {
            Console.WriteLine("Digite um número de 1 a 10");
            numA = int.Parse(Console.ReadLine());

            /*
            if (numA < 1 || numA > 10)
                numValido = false;
            else
                numValido = true;
            */
            if (numA >= 1 && numA <= 10)
            {
                numValido = true;
            }
            else
            {
                Console.WriteLine("O número não é válido!");
                numValido = false;
            }
        }
        Console.WriteLine($"O número {numA} está dentro do limite válido.");
    }
}
