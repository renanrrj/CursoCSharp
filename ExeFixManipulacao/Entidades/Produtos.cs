using System;
using System.Collections.Generic;
namespace ExeFixManipulacao.Entidades
{
    internal class Produtos
    {
        public string nomE { get; set; }
        public double precO { get; set; }
        public int quantidadE { get; set; }

        public Produtos(string name, double price, int quantity)
        {
            nomE = name;
            precO = price;
            quantidadE = quantity;
        }

        public double Total()
        {
            return precO * quantidadE;
        }
    }
}