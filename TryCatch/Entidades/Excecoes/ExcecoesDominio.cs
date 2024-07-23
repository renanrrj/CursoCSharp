namespace TryCatch.Entidades.Excecoes
{
    internal class ExcecoesDominio : ApplicationException
    {
        public ExcecoesDominio(string menssagem) : base(menssagem) { }

    }
}
