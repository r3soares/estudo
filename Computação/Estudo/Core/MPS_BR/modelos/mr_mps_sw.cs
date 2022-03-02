namespace MPS_BR
{
    public class MR_MPS_SW : Modelo
    {
        public Nivel[] Niveis { get; init; }

        public MR_MPS_SW()
        {
            var atributosDeProcesso = new AtributoDeProcesso[]
            {
                new AtributoDeProcesso()
                {
                    Ordem = "AP1.1",
                    Nome = "Processo é Executado"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP2.1",
                    Nome = "Execução do Processo é Gerenciada"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP2.2",
                    Nome = "Produtos de trabalho do processo são gerenciados"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP3.1",
                    Nome = "Processo é Definido"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP3.2",
                    Nome = "Processo está Implementado"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP4.1",
                    Nome = "Processo é objeto de análise quantitativa"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP4.2",
                    Nome = "Processo é controlado Quantitativamente"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP5.1",
                    Nome = "Processo é objeto de melhorias incrementais e inovações"
                },
                new AtributoDeProcesso()
                {
                    Ordem = "AP5.2",
                    Nome = "Processo é Otimizado continuamente"
                },
            };

            var processos = new Processo[]
            {
                new Processo()
                {
                    Sigla = "GPR",
                    Nome = "Gerência de Projetos",
                    Descricao = "Estabelecer e manter planos que definem atividades, recursos e responsabilidades do projeto",
                },
                new Processo()
                {
                    Sigla = "GRE",
                    Nome = "Gerência de Requisitos",
                    Descricao = "Gerenciar os requisitos do produto e dos componentes do produto do projeto e identificar inconsistências",
                },
                new Processo()
                {
                    Sigla = "AQU",
                    Nome = "Aquisição",
                    Opcional = true,
                    Descricao = "Gerenciar a aquisição de produtos que satisfaçam as necessidades do adquirente"
                },
                new Processo()
                {
                    Sigla = "GCO",
                    Nome = "Gerência de Configuração",
                    Descricao = "Estabelecer e manter a integridade de todos os produtos de trabalho de um processo ou projeto",
                },
                new Processo()
                {
                    Sigla = "GPP",
                    Nome = "Gerência de Portfólio de Projetos",
                    Opcional = true,
                    Descricao = "Iniciar e manter projetos que sejam necessários, suficientes e sustentáveis, de forma a atender os objetivos estratégicos da organização",
                },
                new Processo()
                {
                    Sigla = "GQA",
                    Nome = "Garantia da Qualidade",
                    Descricao = "Assegurar que os produtos de trabalho e execução dos processos estejam em conformidade com os planos, procedimentos e padrões estabelecidos",
                },
                new Processo()
                {
                    Sigla = "MED",
                    Nome = "Medição",
                    Descricao = "Coletar, armazenar, analisar e relatar dados relativos aos produtos desenvolvidos e aos processos implementados",
                },
                new Processo()
                {
                    Sigla = "AMP",
                    Nome = "Avaliação e Melhoria do Processo Organizacional",
                    Descricao = "Determinar o quanto os processos padrão da organização contribuem para alcançar os objetivos do negócio da organização",
                },
                new Processo()
                {
                    Sigla = "DFP",
                    Nome = "Definição do Processo Organizacional",
                    Descricao = "Estabelecer e manter um conjunto de ativos de processo organizacional e padrões do ambiente de trabalho usáveis e aplicáveis",
                },
                new Processo()
                {
                    Sigla = "GRH",
                    Nome = "Gerência de Recursos Humanos",
                    Descricao = "Prover a organização e os projetos os recursos humanos necessários e manter suas competências necessárias",
                },
                new Processo()
                {
                    Sigla = "GRU",
                    Nome = "Gerência de Reutilização",
                    Descricao = "Gerenciar o ciclo de vida dos ativos reutilizáveis",
                },
                new Processo()
                {
                    Sigla = "GPR",
                    Nome = "Gerência de Projetos - Evolução",
                    Descricao = "Estabelecer e manter planos que definem atividades, recursos e responsabilidades do projeto",
                },
                new Processo()
                {
                    Sigla = "DRE",
                    Nome = "Desenvolvimento de Requisitos",
                    Descricao = "Definir os requisitos do cliente, do produto e dos componentes do produto",
                },
                new Processo()
                {
                    Sigla = "ITP",
                    Nome = "Integração de Produto",
                    Descricao = "Compor os componentes do produto, produzindo um produto integrado consistente com o seu projeto",
                },
                new Processo()
                {
                    Sigla = "PCP",
                    Nome = "Projeto e Construção de Produto",
                    Descricao = "Projetar, desenvolver e implementar soluções para atender os requisitos",
                },
                new Processo()
                {
                    Sigla = "VAL",
                    Nome = "Validação",
                    Descricao = "Confirmar que um produto ou componente atenderá ao uso pretendido quando colocado no ambiente para qual foi desenvolvido",
                },
                new Processo()
                {
                    Sigla = "VER",
                    Nome = "Verificação",
                    Descricao = "Confirmar que cada serviço e/ou produto de trabalho do processo ou do projeto atenda aos requisitos especificados",
                },
                new Processo()
                {
                    Sigla = "GDE",
                    Nome = "Gerência de Decisão",
                    Descricao = "Analisar possíveis decisões críticas usando processo formal, com critérios estabelecidos",
                },
                new Processo()
                {
                    Sigla = "DRU",
                    Nome = "Desenvolvimento para Reutilização",
                    Descricao = "Identificar oportunidades de reutilização sistemática de ativos da organização",
                    Opcional = true,
                },
                new Processo()
                {
                    Sigla = "GRI",
                    Nome = "Gerência de Riscos",
                    Descricao = "Identificar, analisar, tratar, monitorar e reduzir continuamente os riscos em nível organizacional e de projeto",
                },
                new Processo()
                {
                    Sigla = "GPR",
                    Nome = "Gerência de Projetos",
                    Descricao = "Estabelecer e manter planos que definem atividades, recursos e responsabilidades do projeto",
                },
            };

            Niveis = new Nivel[]
            {
                new Nivel()
                {
                    Categoria = "G",
                    GestaoDoProcesso = "Parcialmente Gerenciado",
                    Atributos = new AtributoDeProcesso[]
                    {
                        atributosDeProcesso[(int)AP.Executado11],
                        atributosDeProcesso[(int)AP.Gerenciado21]
                    },
                    Processos = new Processo[]
                    {
                        processos[(int)ProcessoEnum.GPR1],
                        processos[(int)ProcessoEnum.GRE],
                    }
                },
                new Nivel()
                {
                    Categoria = "F",
                    GestaoDoProcesso = "Gerenciado",
                    Atributos = new AtributoDeProcesso[]
                    {
                        atributosDeProcesso[(int)AP. Executado11],
                        atributosDeProcesso[(int)AP. Gerenciado21],
                        atributosDeProcesso[(int)AP. Gerenciado22],
                    },
                    Processos = new Processo[]
                    {
                        processos[(int)ProcessoEnum.AQU],
                        processos[(int)ProcessoEnum.GCO],
                        processos[(int)ProcessoEnum.GPP],
                        processos[(int)ProcessoEnum.GQA],
                        processos[(int)ProcessoEnum.MED],
                    }
                },
                new Nivel()
                {
                    Categoria = "E",
                    GestaoDoProcesso = "Parcialmente Definido",
                    Atributos = new AtributoDeProcesso[]
                    {
                        atributosDeProcesso[(int)AP. Executado11],
                        atributosDeProcesso[(int)AP. Gerenciado21],
                        atributosDeProcesso[(int)AP. Gerenciado22],
                        atributosDeProcesso[(int)AP. Definido31],
                        atributosDeProcesso[(int)AP. Definido32],
                    },
                    Processos = new Processo[]
                    {
                        processos[(int)ProcessoEnum.AMP],
                        processos[(int)ProcessoEnum.DFP],
                        processos[(int)ProcessoEnum.GRH],
                        processos[(int)ProcessoEnum.GRU],
                        processos[(int)ProcessoEnum.GPR2],
                    }
                },
                new Nivel()
                {
                    Categoria = "D",
                    GestaoDoProcesso = "Largamente Definido",
                    Atributos = new AtributoDeProcesso[]
                    {
                        atributosDeProcesso[(int)AP. Executado11],
                        atributosDeProcesso[(int)AP. Gerenciado21],
                        atributosDeProcesso[(int)AP. Gerenciado22],
                        atributosDeProcesso[(int)AP. Definido31],
                        atributosDeProcesso[(int)AP. Definido32],
                    },
                    Processos = new Processo[]
                    {
                        processos[(int)ProcessoEnum.DRE],
                        processos[(int)ProcessoEnum.ITP],
                        processos[(int)ProcessoEnum.CPC],
                        processos[(int)ProcessoEnum.VAL],
                        processos[(int)ProcessoEnum.VER],
                    }
                },
                new Nivel()
                {
                    Categoria = "C",
                    GestaoDoProcesso = "Definido",
                    Atributos = new AtributoDeProcesso[]
                    {
                        atributosDeProcesso[(int)AP. Executado11],
                        atributosDeProcesso[(int)AP. Gerenciado21],
                        atributosDeProcesso[(int)AP. Gerenciado22],
                        atributosDeProcesso[(int)AP. Definido31],
                        atributosDeProcesso[(int)AP. Definido32],
                    },
                    Processos = new Processo[]
                    {
                        processos[(int)ProcessoEnum.GDE],
                        processos[(int)ProcessoEnum.DRU],
                        processos[(int)ProcessoEnum.GRI],
                    }
                },
                new Nivel()
                {
                    Categoria = "B",
                    GestaoDoProcesso = "Gerenciado Quantitativamente",
                    Atributos = new AtributoDeProcesso[]
                    {
                        atributosDeProcesso[(int)AP. Executado11],
                        atributosDeProcesso[(int)AP. Gerenciado21],
                        atributosDeProcesso[(int)AP. Gerenciado22],
                        atributosDeProcesso[(int)AP. Definido31],
                        atributosDeProcesso[(int)AP. Definido32],
                        atributosDeProcesso[(int)AP. Quantitativo41],
                        atributosDeProcesso[(int)AP. Quantitativo42],
                    },
                    Processos = new Processo[]
                    {
                        processos[(int)ProcessoEnum.GPR3],
                    }
                    
                },
                new Nivel()
                {
                    Categoria = "A",
                    GestaoDoProcesso = "Em Otimização",
                    Atributos = new AtributoDeProcesso[]
                    {
                        atributosDeProcesso[(int)AP. Executado11],
                        atributosDeProcesso[(int)AP. Gerenciado21],
                        atributosDeProcesso[(int)AP. Gerenciado22],
                        atributosDeProcesso[(int)AP. Definido31],
                        atributosDeProcesso[(int)AP. Definido32],
                        atributosDeProcesso[(int)AP. Quantitativo41],
                        atributosDeProcesso[(int)AP. Quantitativo41],
                        atributosDeProcesso[(int)AP. Otimizado51],
                        atributosDeProcesso[(int)AP. Otimizado52],
                    }
                },
            };
        }
    }
}