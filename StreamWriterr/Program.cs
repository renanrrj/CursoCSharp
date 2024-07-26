namespace StreamWriterr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Origem = @"c:\Testes\DocumentoTeste.txt";
            string Destino = @"c:\Testes\DocumentoTeste2.txt";
            try
            {
                string[] lines = File.ReadAllLines(Origem); // Ler todas as linhas e guardar num vetor de strings

                using (StreamWriter sw = File.AppendText(Destino)) // Abre arquivo para a escrita e escreve a partir do final "Append" "Concatenação"
                {
                    foreach (string line in lines) // para cada string line contida no vetor lines
                    {
                        sw.WriteLine(line.ToUpper()); // escrever com letra maiuscula
                    }
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