public class Program
{
    public static void Main(string[] args)
    {
        Mamifero cinodonte = new Mamifero("Cynodontia");
        cinodonte.Respirar();

        Cachorro caoCaramelo = new Cachorro("Canis canis", "Laika");
        caoCaramelo.Respirar();
        caoCaramelo.Latir();

        Pinscher caoPequeno = new Pinscher("Canis canis", "Toby");
        caoPequeno.Respirar();
        caoPequeno.Latir();
        caoPequeno.ModoRaiva();
    }
}
