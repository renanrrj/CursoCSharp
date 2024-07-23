using TryCatch.Entidades;
using TryCatch.Entidades.Excecoes;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Numero do quarto: ");
                    int NQuarto = int.Parse(Console.ReadLine());
                Console.Write("Data de Entrada (dd/MM/yyyy): ");
                    DateTime Entrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Saida (dd/MM/yyyy): ");
                    DateTime Saida = DateTime.Parse(Console.ReadLine());

                Reservas reserva = new Reservas(NQuarto, Entrada, Saida); // Ele Instacia o método reserva já enviando os parâmetros.
                Console.WriteLine("Reservas: " + reserva); // Aqui ele retorna com os dados

                Console.WriteLine();
                Console.WriteLine("Insira dados para atualizar as Reservas:");
                Console.Write("Data de Entrada (dd/MM/yyyy): ");
                    Entrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Saida (dd/MM/yyyy): ");
                    Saida = DateTime.Parse(Console.ReadLine());

                reserva.DatasAtualizadas(Entrada, Saida); // Ele Instacia o método DatasAtualizadas já enviando os parâmetros.
                Console.WriteLine("Reservas: " + reserva); // Aqui ele retorna com os dados novos
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro no formato: " + e.Message);
            }
            catch (ExcecoesDominio e)
            {
                Console.WriteLine("Error na reserva: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}