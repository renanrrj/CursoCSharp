using TryCatch_exefix_.Entidades;
using TryCatch_exefix_.Entidades.Excecoes;

namespace TryCatch_exefix_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Dados da conta");
                Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                Console.Write("Número: ");
                int NumConta = int.Parse(Console.ReadLine());
                Console.Write("Valor inicial: R$ ");
                    double ValInicial = double.Parse(Console.ReadLine());
                Console.Write("Saque limite: R$ ");
                    double ValMaxSaque = double.Parse(Console.ReadLine());

                double ValSaque = 0;

                Contas conta = new Contas (Nome, NumConta, ValInicial, ValMaxSaque, ValSaque);
                
                conta.Deposito(ValInicial, ValMaxSaque);

                Console.WriteLine();
                Console.Write("Insira valor para saque: R$ ");
                    ValSaque = double.Parse(Console.ReadLine());

                conta.Saque(ValSaque, ValMaxSaque, ValInicial);

                Console.WriteLine(" -> Valor disponivel: R$ " + conta);
            }

            catch (DominioExcecao e)
            {
                Console.WriteLine("Erro na conta: " + e.Message);
            }


        }
    }
}
