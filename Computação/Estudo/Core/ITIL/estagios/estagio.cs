namespace Computacao.ITIL
{
    public abstract class Estagio
    {
        public string Nome { get; init; }
        public string Descricao { get; init; }

        public string[] Objetivos { get; init; }

        public Processo[] Processos { get; init; }
    }
}