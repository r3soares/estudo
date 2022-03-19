namespace Computacao.ITIL
{
    public class GerenciamentoProblemas : Processo
    {
        public Dictionary<string,string> GestaoDeProblema { get; init; }
        public Dictionary<string,string> Atividades { get; init; }

        /// <summary>
        /// M�todos para an�lise e solu��o de problemas sugeridos pela ITIL 
        /// </summary>
        public Dictionary<string, string> Metodos { get; init; }


        public GerenciamentoProblemas()
        {
            GestaoDeProblema = new Dictionary<string, string>()
            {
                {"Reativo","Analisar a causa dos principais incidentes ocorridos, procurando resolver a causa, evitando a recorr�ncia"},
                {"Proativo","Atrav�s da an�lise de informa��es dos indicadores, procura por oportunidades de melhoria. Pode gerar entradas para o Plano de Melhoria de Servi�o"},
            };

            Atividades = new Dictionary<string, string>
            {
                {"Identifica��o", "" },
                {"Registro", "" },
                {"Classifica��o", ""},
                {"Prioriza��o", ""},
                {"Investiga��o e Diagn�stico", ""},
                {"Identifica��o de Erros Conhecidos", ""},
                {"Resolu��o de Problemas", ""},
                {"Encerramento","" },
                {"Revis�o de Problema Grave","" },
            };

            Metodos = new Dictionary<string, string>()
            {
                {"An�lise Cronol�gica","Rastro cronol�gico que pode ter conduzido ao problema" },
                {"An�lise de 'dor'","An�lise de impacto na organiza��o" },
                {"Kepner e Tregoe","Defini e descreve o problema. Estabelece poss�veis causas. Testa a causa mais prov�vel e verifica a verdadeira causa" },
                {"Brainstorm","Tempestade de ideias" },
                {"Mapeamento por afinidade","Organiza uma grande quantidade de informa��es por assunto" },
                {"5 porqu�s","" },
                {"Isolamento da falha","Reexecuta as rotinas para identificar aonde est� o problema e aonde n�o est�" },
                {"Teste por hip�tese","" },
                {"Observa��o","" },
                {"Diagrama de Ishikawa","" },
                {"Pareto","" },
            };
        }
    }
}