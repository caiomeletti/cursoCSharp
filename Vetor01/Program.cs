public class Program
{
    public static void Main(string[] args)
    {
        float[] notas = new float[4];
        float soma = 0;
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Insira a {i + 1}a. nota: ");
            string n = Console.ReadLine();
            notas[i] = float.Parse(n);

            soma = soma + notas[i];
        }
        Console.WriteLine();
        Console.WriteLine($"A média é {soma / 4}");
        Console.WriteLine();
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine($"Nota {i + 1}: {notas[i]}");
        }
    }
}