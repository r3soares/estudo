namespace Computacao.ITIL
{
    public class GerenciamentoDisponibilidade : Processo
    {
        public Dictionary<string,string> PrincipaisProdutos { get; init; }
        public Dictionary<string,string> Glossario { get; init; }        
        
        //Tempo total em que o serviço ficou operacional
        public float TotalUptime { get; set; }
        //Tempo Total de Manutenção
        public float TempoFalhas { get; set; }
        //Quantiadade de falhas
        public int QtdFalhas { get; set; }
        //ITIL v4, substituiu MTBSI
        public float MTBF => TotalUptime / QtdFalhas;
        //Descontinuado na ITIL v4
        public float MTTR => TempoFalhas / QtdFalhas;
        //ITIL v4
        public float MTRS => MTTR;
        //Descontinuado na ITIL v4
        public float MTBSI => MTBF + MTTR;
        //Ou Uptime
        public float Disponibilidade => MTBF / (MTBF + MTTR);

        public GerenciamentoDisponibilidade()
        {
            PrincipaisProdutos = new Dictionary<string, string>()
            {
                {"Distema de Informação de Gestão de Disponibilidade (SIGD)","Contém todas as medições e dados necessários para fornecer informações dobre a disponibilidade do negócio"},
                {"Plano de Disponibilidade","Dividido em Atividades reativas e proativas"},
            };
            Glossario = new Dictionary<string, string>()
            {
                {"Mean Time To Repair (MTTR)","Tempo médio para correção de uma falha"},
                {"Mean Time Restore Service (MTRS)","Downtime ou tempo médio para restaurar um item de configuração ou serviço após uma falha (ITIL v4)"},
                {"Mean Time Between Failure (MTBF)","Uptime ou tempo médio entre a recuperação de um incidente e a ocorrência do próximo incidente"},
                {"Mean Time Between System Incidents (MTBSI)","Tempo médio entre a ocorrência de dois incidentes consecutivos"},
                {"Disponibilidade","Capacidade de um serviço, componente ou item de configuração desempenhar suas funções acordadas quando necessário"},
                {"Confiabilidade","Tempo que um serviço ou componente pode funcionar sem interrupção"},
                {"Sustentabilidade","Rapidez com que um serviço ou componente é restaurado após uma falha"},
                {"Funcionalidade","Habilidade de um fornecedor externo em atender os termos de seu contrato"},
            };
        }
    }
}