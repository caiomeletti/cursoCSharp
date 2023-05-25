public abstract class Pessoa
{
    private string nome;
    private string telefoneCelular;
    private string email;
    Endereco endereco;

    private bool possuiPasseEstacionamento;
    private DateTime validadePasseEstacionamento;

    public void ComprarPasseEstacionamento()
    {
        if (!possuiPasseEstacionamento)
        {
            possuiPasseEstacionamento = true;
            validadePasseEstacionamento = DateTime.Now.AddDays(30);
        }
    }
}