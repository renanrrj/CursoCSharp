using TryCatch_exefix_.Entidades;
using TryCatch_exefix_.Entidades.Excecoes;

namespace TryCatch_exefix_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da conta");
            Console.Write("Nome: ");
                string Nome = Console.ReadLine();
            Console.Write("Número: ");
                int NumConta = int.Parse(Console.ReadLine());
            Console.Write("Valor inicial: ");
                double ValInicial = double.Parse(Console.ReadLine());
            Console.Write("Saque limite: ");
                double ValMaxSaque = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Inisra valor para saque");
                double ValSaque = double.Parse(Console.ReadLine());

            
            Console.WriteLine("Valor disponivel: R$");


        }
    }
}
