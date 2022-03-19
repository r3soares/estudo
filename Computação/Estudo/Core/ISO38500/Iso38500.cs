
namespace Computacao.ISO38500
{
    public class Iso38500
    {
        public string Objetivo { get; init; }
        public Dictionary<string,string> Principios { get; init; }

        public Dictionary<string,string> TarefasEssenciais { get; init; }

        public Iso38500()
        {
            Objetivo = @"Fornecer uma estrutura de princípios para os dirigentes utilizarem na avaliação, 
            direção e monitoramento do uso da TI em suas organizações";

            Principios = new Dictionary<string, string>()
            {
                {"Responsabilidade",@"Indivíduos e grupos dentro da organização compreendem e aceitam 
                    suas responsabilidades com respeito ao fornecimento e à demanda de TI. Aqueles 
                    responsáveis pelas ações também têm autoridade para desempenhar tais ações"},
                {"Estratégia",@"A Estratégia de negócio da organização considera as capacidades atuais e 
                    futuras da TI. Os planos estratégicos de TI contemplam as necessidades atuais e contínuas do 
                    negócio"},
                {"Aquisição",@"As aquisições de TI são realizadas por motivos válidos, com base em análises 
                    apropriadas, com tomada de decisão clara e transparente. Benefícios, oportunidades, custos 
                    e riscos são equilibrados no curto, médio e longo prazo"},
                {"Desempenho",@"A TI é adequada às necessidades da organização, capaz de fornecer serviços 
                    com a qualidade necessária para atender aos requisitos atuais e futuros da organização"},
                {"Conformidade",@"A TI está alinhada às legislações e marcos regulatórios. Políticas e práticas 
                    são definidas, implementadas e fiscalizadas"},
                {"Comportamento Humano",@"A TI está alinhada às legislações e marcos regulatórios. Políticas e práticas 
                    são definidas, implementadas e fiscalizadas"},
            };

            TarefasEssenciais = new Dictionary<string, string>()
            {
                {"Avaliar","Uso atual e futuro da TI"},
                {"Dirigir","A preparação e a implementação de planos e políticas para assegurar que a TI atenda aos objetivos do negócio"},
                {"Monitorar","O cumprimento destas políticas em relação aos planos"},
            };
        }
    }
}