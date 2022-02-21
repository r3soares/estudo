namespace MPS_BR
{
    public enum ProcessoEnum
    {
        GPR1,
        GRE,
        AQU,
        GCO,
        GPP,
        GQA,
        MED,
        AMP,
        DFP,
        GRH,
        GRU,
        GPR2,
        DRE,
        ITP,
        CPC,
        VAL, 
        VER,
        GDE,
        DRU,
        GRI,
        GPR3,

    }
    public struct Processo
    {
        public string Sigla { get; init; }
        public string Nome { get; init; }
        public bool Opcional { get; set; } = false;
        public string Descricao { get; init; }
    }
}