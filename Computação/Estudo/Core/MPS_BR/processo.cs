namespace Computacao.MPS_BR
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
        public string Sigla;
        public string Nome;
        public bool Opcional;
        public string Descricao;
    }
}