namespace ITIL
{
    public class Estrategia : Estagio
    {
        public SLP ProdutoPrincipal { get; init; }        
        public string[] Recursos { get; init; }
        public string[] Habilidades { get; init; }
        public string[] AtivosEstrategicos { get; init; }
        public Dictionary<string,string> Ps { get; init; }

        public Estrategia()
        {
            ProdutoPrincipal = new SLP()
            {
                Nome = "Service Level Package",
                Descricao = "Produto principal da Estratégia de Serviços define o valor dos serviços em termos de Utilidade e Garantia",
            };
            Recursos = new string[] //Coisas tangíveis
            {
                "Pessoas",
                "Informação",
                "Aplicações",
                "Infraestrutura",
                "Capital",
            };

            Habilidades = new string[] //Intangíveis
            {
                "Pessoas",
                "Processos",
                "Conhecimento",
                "Gerenciamento",
                "Organização",
            };

            AtivosEstrategicos = Recursos.Union(Habilidades).ToArray();
            
            Ps = new Dictionary<string, string>()
            {
                {"Perspectiva","Visão da organização, valores e convicções"},
                {"Posição","Imagem que a organização pretende passar para o cliente"},
                {"Plano","Estratégia que torna a organização competitiva, e como será executada"},
                {"Padrão","Procedimentos da organização, fruto das definições de perspectiva, posição e plano"},
            };

            Processos = new Processo[]
            {
                new GerenciamentoEstrategia()
                {
                    Nome = "Gerenciamento da Estratégia de Serviços de TI",
                    Objetivo = "Desenvolvimento e manutenção das estratégias de TI. Utiliza a técnica de análise SWOT",
                },
                new GerenciamentoPortfolio()
                {
                    Nome = "Gerenciamento de Portifólio de Serviços",
                    Objetivo = "Fornece informações sobre os serviços em qualquer estágio do ciclo de vida",
                },
                new GerenciamentoDemanda()
                {
                    Nome = "Gerenciamento da Demanda",
                    Objetivo = "Interpretação da demanda e o fornecimento de capacidade para atendimento da demanda",
                },
                new GerenciamentoFinanceiro()
                {
                    Nome = "Gerenciamento Financeiro",
                    Objetivo = "Determinar quanto custa desenvolver e manter um serviço e gerenciar recursos para atendimento das demandas",
                },
                new GerenciamentoNegocio()
                {
                    Nome = "Gerenciamento do Relacionamento com o Negócio",
                    Objetivo = "Manter o relacionamento entre o provedor de serviços e o cliente nos níveis estratégicos e táticos",
                }
            };

        }
    }
}