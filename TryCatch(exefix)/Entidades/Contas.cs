using System.Security.Cryptography.X509Certificates;
using TryCatch_exefix_.Entidades.Excecoes;
namespace TryCatch_exefix_.Entidades
{
    internal class Contas
    {
        public string Nome { get; set; }
        public int NumConta { get; set; }
        public double ValorI { get; set; }
        public double ValorMS { get; set; }
        public double ValorS { get; set; }

        public Contas (string nome, int numConta, double valorI, double valorMS, double valorS)
        {
            if (valorI < valorMS)
            {
                throw new DominioExcecao("Valor Inicial MENOR que o Valor Máximo de saque");
            }

            Nome = nome;
            NumConta = numConta;
            ValorI = valorI;
            ValorMS = valorMS;
            ValorS = valorS;
        }
        public void Deposito(double valorI, double valorMS)
        {
            if (valorI < valorMS || valorMS > valorI)
            {
                throw new DominioExcecao("Valor Inicial MENOR que o Valor Máximo de saque");
            }
        }

        double ValorD = 0;
        public void Saque (double valorS, double valorMS, double valorI)
        {
            if (valorS > valorMS)
            {
                throw new DominioExcecao("Valor MAIOR Do que o permitido para saque");
            }
            else
            {
                double valord = valorI - valorS;
                ValorD = valord; 
            }            
        }

        public override string ToString()
        {
            return "" + ValorD;
        }

    }
}
