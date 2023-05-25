class Exemplo
{
    public static void Main()
    {
        var s = new Acme.Colecoes.Pilha<int>();
        s.Empurrar(1); // pilha contém 1
        s.Empurrar(10); // pilha contém 1, 10
        s.Empurrar(100); // pilha contém 1, 10, 100
        Console.WriteLine(s.Retirar()); // pilha contém 1, 10
        Console.WriteLine(s.Retirar()); // pilha contém 1
        Console.WriteLine(s.Retirar()); // pilha está vazia
    }
}

