namespace Pathh
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\file1.txt";

            Console.WriteLine("Separa Caractere: " + Path.DirectorySeparatorChar);

            Console.WriteLine("Separação de pasta: " + Path.PathSeparator);

            Console.WriteLine("Pega nome do diretorio: " + Path.GetDirectoryName(path));

            Console.WriteLine("Pega o Nome do arquivo: " + Path.GetFileName(path));

            Console.WriteLine("Pega extensão do arquivo: " + Path.GetExtension(path));

            Console.WriteLine("Pega nome do arquivo sem extensao: " + Path.GetFileNameWithoutExtension(path));

            Console.WriteLine("Pega endereço completo: " + Path.GetFullPath(path));

            Console.WriteLine("Pega pasta temporaria do sistema: " + Path.GetTempPath()); // para manipular dados temporarios de aplicações
        }
    }
}