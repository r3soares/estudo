namespace MPS_BR
{
    public enum AP
    {
        Executado11,
        Gerenciado21,
        Gerenciado22,
        Definido31,
        Definido32,
        Quantitativo41,
        Quantitativo42,
        Otimizado51,
        Otimizado52,
    }
    public struct AtributoDeProcesso
    {
        public string Ordem { get; init; }
        public string Nome { get; init; }
    }
}