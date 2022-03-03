namespace ITIL
{
    public class GerenciamentoMudanca : Processo
    {
        public Dictionary<string,string> Conceitos { get; init; }
        public string[] Rs { get; init; }

        public GerenciamentoMudanca()
        {
            Conceitos = new Dictionary<string, string>()
            {
                {"Requisições de Mudanças (RDM ou RFC)","Requisições formais para mudar um ou mais Itens de Configuração"},
                {"Comitê Consultivo de Mudança (CCM)","Pessaos que autorizam a mudança e auxiliam na sua avaliação e priorização"},
            };

            Rs = new string[]
            {
                "Quem é o Requisitante da Mudança",
                "Qual é a Razão para a Mudança",
                "Qual é o Retorno exigido pela Mudança",
                "Quais são os Riscos envolvidos na Mudança",
                "Quais Recursos necessários para entregar a mudança",
                "Quem é Responsável pela construção, teste e implementação da Mudança",
                "Qual é a Relação entre essa mudança e outras mudanças",
            };
        }
    }
}