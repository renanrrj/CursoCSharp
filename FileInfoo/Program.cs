namespace FileInfoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\Testes\DocumentoTeste.txt";
            string targetPath = @"c:\Testes\DocumentoTeste2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); // Copia desse arquivo "sourcePath"
                fileInfo.CopyTo(targetPath); //Salva nesse arquivo "targetPath"

                string[] lines = File.ReadAllLines(sourcePath); // Cria um vetor de string para leitura e armazenameto
                foreach (string line in lines) // Aqui percorre o documento e lista os ítens
                {
                    Console.WriteLine(line); //aqui exibe os ítens na tela
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