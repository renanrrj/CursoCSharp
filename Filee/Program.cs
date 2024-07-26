namespace Filee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\Testes\DocumentoTeste.txt";
            string targetPath = @"c:\Testes\DocumentoTeste2.txt";

            try
            {
                File.Copy(sourcePath, targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
