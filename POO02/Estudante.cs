public class Estudante : Pessoa
{
    private long numeroEstudante;
    private double notaMedia;

    public bool ElegivelParaInscrisao()
    {
        return notaMedia > 6;
    }

    public void FazerSeminario()
    {
        Console.WriteLine("Participando do seminário.");
    }
}