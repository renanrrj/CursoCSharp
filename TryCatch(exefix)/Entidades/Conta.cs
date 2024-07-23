using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_exefix_.Entidades
{
    internal class Conta
    {

        public int NumConta{ get; set; }
        public string Cliente { get; set; }
        public double ValInical { get; set; }
        public double ValLimite { get; set; }

        public Conta(int numConta, string cliente, double valInical, double valLimite)
        {
            NumConta = numConta;
            Cliente = cliente;
            ValInical = valInical;
            ValLimite = valLimite;
        }

    }
}
