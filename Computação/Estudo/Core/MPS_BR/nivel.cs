namespace Computacao.MPS_BR
{
    public struct Nivel
    {
        public string Categoria { get; init; }
        public string GestaoDoProcesso { get; init; }

        public AtributoDeProcesso[] Atributos { get; init; }

        public Processo[] Processos { get; init; }
    }
}