namespace Computacao.CMMI
{
    public struct Nivel
    {
        public int Ordem { get; init; }
        public string Nome { get; init; }
        public string Descricao { get; init; }

        public AreaDoProcesso[] Areas { get; init; }
    }
}