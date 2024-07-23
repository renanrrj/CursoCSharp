using TryCatch.Entidades.Excecoes;

namespace TryCatch.Entidades
{
    internal class Reservas
    {
        public int NumQuarto { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }

        public Reservas (int numQuarto, DateTime entrada, DateTime saida)
        {

            if (saida <= entrada)
            {
                throw new ExcecoesDominio("A data de saída deve ser posterior à data de Entrada");
            }

            NumQuarto = numQuarto;
            Entrada = entrada;
            Saida = saida;
        }

        public double Duration()
        {
            TimeSpan duration = Saida.Subtract(Entrada);
            return (int)duration.TotalDays;
        }

        public void DatasAtualizadas(DateTime entrada, DateTime saida)
        {
            DateTime DtAgora = DateTime.Now;
            if (entrada < DtAgora || saida < DtAgora)
            {
                throw new ExcecoesDominio("1- As datas das reservas para atualização devem ser datas futuras");
            }
            else if (saida <= entrada)
            {
                throw new ExcecoesDominio("2- A data de saída deve ser posterior à data de entrada");
            }

            Entrada = entrada;
            Saida = saida;
        }

        public override string ToString()
        {
            return "Quarto "
                + NumQuarto
                + ", Entrada: "
                + Entrada.ToString("dd/MM/yyyy")
                + ", Saida: "
                + Saida.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " noites";
        }
    }
}
