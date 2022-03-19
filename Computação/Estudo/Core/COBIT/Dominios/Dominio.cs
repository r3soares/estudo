namespace Computacao.COBIT
{
    public abstract class Dominio
    {
        public string Sigla { get; init; }
        public string Nome { get; init; }
        public string Objetivo { get; init; }
        public Processo[] Processos { get; init; }
    }
}