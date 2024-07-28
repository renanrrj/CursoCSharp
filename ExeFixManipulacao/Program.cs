using System.Globalization;
using ExeFixManipulacao.Entidades;
namespace ExeFixManipulacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Caminho = @"c:\Testes";
            string Origem = @"c:\Testes\ArqOrigem.csv";
            string Destino = @"c:\Testes\out\summary.csv";

            try {
                string[] linhas = File.ReadAllLines(Origem);

                Directory.CreateDirectory(@"C:\Testes\out"); // Criação da pasta "out"

                using (StreamWriter sw = File.AppendText(Destino))
                { 
                    foreach (string linha in linhas)
                    {

                        string[] Campos = linha.Split(',');
                        string Nome = Campos[0];
                        double Preco = double.Parse(Campos[1], CultureInfo.InvariantCulture);
                        int Quantidade = int.Parse(Campos[2]);

                        Produtos prod = new Produtos(Nome, Preco, Quantidade);

                        sw.WriteLine(prod.nomE + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("PARABÉNS ENCERRADO COM SUCESSO");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("ATENÇÃO OCORREU UM ERRO!! -> " + ex.Message);
            }
        }
    }
}
