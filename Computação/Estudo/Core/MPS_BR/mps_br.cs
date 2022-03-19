namespace Computacao.MPS_BR
{
    public class MPSBR
    {
        public string Objetivo { get; init; } = "Melhoria de Processo de Software e Serviços, com duas metas a alcançar a médio e longo prazo com em micro, pequenas e médias empresas (foco principal) e também nas grandes organizações privadas e governamentais";
        public Meta[] Metas { get; init; }

        public Modelo[] Modelos { get; init; }
        public MPSBR()
        {
            Metas = new Meta[] 
            {   
                new Meta()
                {
                    Nome = "Técnica",
                    Objetivo = "Criação e aprimoramento do Modelo MPS",
                },
                new Meta()
                {
                    Nome = "Negócio",
                    Objetivo = "Disseminação e adoção do Modelo pelo país em um intervalo de tempo justo, a um custo razoável",
                }
            };

            Modelos = new Modelo[]
            {
                new MR_MPS_SW()
                {
                    Nome = "MR-MPS-SW",
                    Componentes = new Componente[]
                    {
                        new Componente()
                        {
                            Nome = "Guia Geral MPS de Software",
                            Descricao = "Descrição geral do modelo MPS e detalha o Modelo de Referência MPS para Software, seus componentes e definições",
                        },
                        new Componente()
                        {
                            Nome = "Guia de Aquisição",
                            Descricao = "Descreve um processo de aquisição de software e serviços correlatos",
                        },
                        new Componente()
                        {
                            Nome = "Guia de Avaliação",
                            Descricao = "Descreve o proceso e o método de avaliação MA-MPS",
                        },
                        new Componente()
                        {
                            Nome = "Guia de Implementação",
                            Descricao = "Série de documentos que fornecem orientações para implementar nas organizações os níveis de maturidade descritos no modelo MR-MPS-SW",
                        },
                    }                    
                }
            };
        }
    }

}
