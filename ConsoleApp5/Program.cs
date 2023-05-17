public class Program
{
    public static void Main(string[] args)
    {
        int ANO_ATUAL = DateTime.Now.Year;
        int anoMin = ANO_ATUAL - 150;
        int anoN = 0;
        string? anoNasc = "";
        bool parseOK = false;
        bool anoMinOk = false;
        bool anoMaxOk = false;
        do
        {
            Console.WriteLine("Qual o seu ano de nascimento?");
            anoNasc = Console.ReadLine();

            if (int.TryParse(anoNasc, out anoN))
                parseOK = true;
            else
                parseOK = false;

            if (anoN < anoMin)
            {
                Console.WriteLine($"O ano deve ser maior que {anoMin}");
                anoMinOk = false;
            }
            else
                anoMinOk = true;

            if (anoN > ANO_ATUAL)
            {
                Console.WriteLine($"O ano deve ser menor que {ANO_ATUAL}");
                anoMaxOk = false;
            }
            else
                anoMaxOk = true;

        } while (!parseOK || !anoMinOk || !anoMaxOk);

        int idade = ANO_ATUAL - anoN;
        Console.WriteLine($"Você tem {idade} anos de idade.");
    }
}
