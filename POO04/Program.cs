public class Program
{
    public static void Main(string[] args)
    {
        Motorista m1 = new Motorista();
        m1.Dirigir(new Veiculo());
        Console.WriteLine();

        m1.Dirigir(new Carro());
        Console.WriteLine();

        m1.Dirigir(new Motocicleta());
        Console.WriteLine();
    }
}