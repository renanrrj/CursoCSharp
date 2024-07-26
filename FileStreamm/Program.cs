namespace FileStreamm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Testes\DocumentoTeste.txt";

            FileStream fs = null; // instanciação do FileStream
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open); // File.OpenRead(path);
                sr = new StreamReader(fs);

                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close(); //Fechar manualmente 
                if (fs != null) fs.Close();
            }
        }
    }
}
