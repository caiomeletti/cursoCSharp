public class Program
{
    public static void Main(string[] args)
    {
        DriveInfo[] mostraDrive = DriveInfo.GetDrives();

        Console.WriteLine("Unidades");
        Console.WriteLine("--------");
        int unidade = 0;
        foreach (DriveInfo dr in mostraDrive)
        {
            Console.WriteLine($"{unidade} - {dr.Name}");
            unidade++;
        }

        //Console.WriteLine();
        //Console.WriteLine("Digite o número da unidade desejada:");
        // unidadeEscolhida <-- Receber a unidade escolhida pelo usuário;
        
        Console.WriteLine();
        Console.WriteLine("Name: " + mostraDrive[3].Name);
        Console.WriteLine("AvailableFreeSpace: " + mostraDrive[3].AvailableFreeSpace);
        Console.WriteLine("DriveFormat: " + mostraDrive[3].DriveFormat);
        Console.WriteLine("DriveType: " + mostraDrive[3].DriveType);
    }
}