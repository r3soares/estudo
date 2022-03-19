namespace Computacao.ITIL
{
    public class GerenciamentoContinuidade : Processo
    {
        public int HotStandby => 24;
        public int WarmStandby => 72;
        public int ColdStandby => int.MaxValue;
        public Dictionary<string,string> Glossario { get; init; }   

        public GerenciamentoContinuidade()
        {
            Glossario = new Dictionary<string, string>()
            {
                {"Desastre (catástrofe)","Não é parte das atividades diárias e requer um sistema separado"},
                {"Contramedidas","Medidas para prevenir ou recuperar de um desastre"},
                {"Workaround Manual","Uso de solução não baseada em TI para superar uma interrupção de serviços de TI"},
                {"Recuperação Gradual","Cold Standby (ou Cold Site) > 72h de recuperação"},
                {"Recuperação Intermediária","Warm Standby 24h a 72h de recuperação"},
                {"Recuperação Rápida ou Imediata","Hot Standby <24h, implica geralmente 1 a 2 horas"},
                {"Acordo Recíproco","Acordo com outra empresa de dimensão semelhante para compartilhar obrigações relativas a recuperação de desastres. Contingência"},
            };
        }
    }
}