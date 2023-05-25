namespace Acme.Colecoes;

public class Pilha<T>
{
    Entrada _topo;

    public void Empurrar(T dado)
    {
        _topo = new Entrada(_topo, dado);
    }

    public T Retirar()
    {
        if (_topo == null)
        {
            throw new InvalidOperationException();
        }
        T result = _topo.Data;
        _topo = _topo.Proximo;

        return result;
    }

    class Entrada
    {
        public Entrada Proximo { get; set; }
        public T Data { get; set; }

        public Entrada(Entrada proximo, T data)
        {
            Proximo = proximo;
            Data = data;
        }
    }
}