namespace ITIL
{
    public class GerenciamentoProblemas : Processo
    {
        public Dictionary<string,string> GestaoDeProblema { get; init; }
        public Dictionary<string,string> Atividades { get; init; }

        /// <summary>
        /// Métodos para análise e solução de problemas sugeridos pela ITIL 
        /// </summary>
        public Dictionary<string, string> Metodos { get; init; }


        public GerenciamentoProblemas()
        {
            GestaoDeProblema = new Dictionary<string, string>()
            {
                {"Reativo","Analisar a causa dos principais incidentes ocorridos, procurando resolver a causa, evitando a recorrência"},
                {"Proativo","Através da análise de informações dos indicadores, procura por oportunidades de melhoria. Pode gerar entradas para o Plano de Melhoria de Serviço"},
            };

            Atividades = new Dictionary<string, string>
            {
                {"Identificação", "" },
                {"Registro", "" },
                {"Classificação", ""},
                {"Priorização", ""},
                {"Investigação e Diagnóstico", ""},
                {"Identificação de Erros Conhecidos", ""},
                {"Resolução de Problemas", ""},
                {"Encerramento","" },
                {"Revisão de Problema Grave","" },
            };

            Metodos = new Dictionary<string, string>()
            {
                {"Análise Cronológica","Rastro cronológico que pode ter conduzido ao problema" },
                {"Análise de 'dor'","Análise de impacto na organização" },
                {"Kepner e Tregoe","Defini e descreve o problema. Estabelece possíveis causas. Testa a causa mais provável e verifica a verdadeira causa" },
                {"Brainstorm","Tempestade de ideias" },
                {"Mapeamento por afinidade","Organiza uma grande quantidade de informações por assunto" },
                {"5 porquês","" },
                {"Isolamento da falha","Reexecuta as rotinas para identificar aonde está o problema e aonde não está" },
                {"Teste por hipótese","" },
                {"Observação","" },
                {"Diagrama de Ishikawa","" },
                {"Pareto","" },
            };
        }
    }
}