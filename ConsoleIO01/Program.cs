// escrever um arquivo texto
Console.WriteLine("Olá, qual é o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual é a sua data de nascimento?");
string dataNasc = Console.ReadLine();

Console.WriteLine("Em que cidade você nasceu?");
string naturalidade = Console.ReadLine();

TextWriter arq = File.CreateText(@"D:\repos\cursoCSharp\teste.txt");
arq.WriteLine(nome);
arq.WriteLine(dataNasc);
arq.WriteLine(naturalidade);
arq.Close();

// abrir um  arquivo texto
TextReader tr = File.OpenText(@"D:\repos\cursoCSharp\teste.txt");
Console.WriteLine();
Console.WriteLine(@"Conteúdo do arquivo D:\repos\cursoCSharp\teste.txt");
Console.WriteLine("---");
Console.WriteLine(tr.ReadToEnd());
tr.Close();

// abrir arquivo lendo apenas 1 linha
Console.WriteLine("Insira o número da linha desejada (1 a 3)");
string numLinha = Console.ReadLine();

StreamReader sr = new StreamReader(@"D:\repos\cursoCSharp\teste.txt");
int i = 0;
while (!sr.EndOfStream)
{
    string line = sr.ReadLine();
    i++;
    if (i == int.Parse(numLinha))
    {
        Console.WriteLine(line);
        break;
    }
}
sr.Close();

if (File.Exists(@"D:\repos\cursoCSharp\teste.txt"))
    File.Delete(@"D:\repos\cursoCSharp\teste.txt");
