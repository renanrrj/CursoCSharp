namespace DirectoryDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Testes";
            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // Listar todas "*.*" as pasatas a partir da pasta string path

                Console.WriteLine("FOLDERS:");
                    foreach (string s in folders)
                    {
                        Console.WriteLine(s);
                    }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // Listar todas "*.*" os arquivos a partir da pasta "path"

                Console.WriteLine("FILES:");
                    foreach (string s in files)
                    {
                        Console.WriteLine(s);
                    }

                Directory.CreateDirectory(@"c:\Testes\newfolder"); // Criar uma pasta "new folder"
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}