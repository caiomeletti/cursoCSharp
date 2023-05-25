class Entidade
{
    static int numSerial_estatico;
    int numSerial;

    public Entidade()
    {
        numSerial = numSerial_estatico;
        numSerial_estatico++;
    }

    public int ObterNumSerial()
    {
        return numSerial;
    }

    public static int ObterProximoNumSerial()
    {
        return numSerial_estatico;
    }

    public static void AtribuirProximoNumSerial(int value)
    {
        numSerial_estatico = value;
    }
}

class Program
{
    static void Main()
    {
        Entidade.AtribuirProximoNumSerial(1000);
        Entidade e1 = new();
        Entidade e2 = new();
        Console.WriteLine(e1.ObterNumSerial());          //  "1000"
        Console.WriteLine(e2.ObterNumSerial());          //  "1001"
        Console.WriteLine(Entidade.ObterProximoNumSerial());  //  "1002"
    }
}